using Microsoft.AspNetCore.Mvc;
using Afonsoft.Ranking.DashboardCustomization;
using Afonsoft.Ranking.DashboardCustomization.Dto;
using Afonsoft.Ranking.Web.Areas.App.Models.CustomizableDashboard;
using Afonsoft.Ranking.Web.Controllers;
using System.Linq;
using System.Threading.Tasks;
using Afonsoft.Ranking.Web.Areas.App.Startup;

namespace Afonsoft.Ranking.Web.Areas.App.Controllers
{
    public abstract class CustomizableDashboardControllerBase : RankingControllerBase
    {
        protected readonly IDashboardCustomizationAppService DashboardCustomizationAppService;
        protected readonly DashboardViewConfiguration DashboardViewConfiguration;

        protected CustomizableDashboardControllerBase(
            DashboardViewConfiguration dashboardViewConfiguration, 
            IDashboardCustomizationAppService dashboardCustomizationAppService)
        {
            DashboardViewConfiguration = dashboardViewConfiguration;
            DashboardCustomizationAppService = dashboardCustomizationAppService;
        }

        public async Task<PartialViewResult> AddWidgetModal(string dashboardName, string pageId)
        {
            var userDashboard = await DashboardCustomizationAppService.GetUserDashboard(
                new GetDashboardInput
                {
                    DashboardName = dashboardName,
                    Application = RankingDashboardCustomizationConsts.Applications.Mvc
                }
            );

            var page = userDashboard.Pages.Single(p => p.Id == pageId);

            var filteredWidgetsByPermission = DashboardCustomizationAppService.GetAllWidgetDefinitions(new GetDashboardInput() { DashboardName = dashboardName })
                .Where(widgetDef => page.Widgets.All(widgetOnPage => widgetOnPage.WidgetId != widgetDef.Id))
                .ToList();

            var viewModel = new AddWidgetViewModel
            {
                Widgets = filteredWidgetsByPermission,
                DashboardName = dashboardName,
                PageId = pageId
            };

            return PartialView("~/Areas/App/Views/Shared/Components/CustomizableDashboard/_AddWidgetModal.cshtml", viewModel);
        }

        protected async Task<ActionResult> GetView(string dashboardName)
        {
            var dashboardDefinition = DashboardCustomizationAppService.GetDashboardDefinition(
                new GetDashboardInput
                {
                    DashboardName = dashboardName,
                    Application = RankingDashboardCustomizationConsts.Applications.Mvc
                }
            );

            var userDashboard = await DashboardCustomizationAppService.GetUserDashboard(new GetDashboardInput
                {
                    DashboardName = dashboardName,
                    Application = RankingDashboardCustomizationConsts.Applications.Mvc
                }
            );

            // Show only view defined widgets
            foreach (var userDashboardPage in userDashboard.Pages)
            {
                userDashboardPage.Widgets = userDashboardPage.Widgets
                    .Where(w => DashboardViewConfiguration.WidgetViewDefinitions.ContainsKey(w.WidgetId)).ToList();
            }

            dashboardDefinition.Widgets = dashboardDefinition.Widgets.Where(dw => userDashboard.Pages.Any(p => p.Widgets.Select(w => w.WidgetId).Contains(dw.Id))).ToList();

            return View("~/Areas/App/Views/Shared/Components/CustomizableDashboard/Index.cshtml",
                new CustomizableDashboardViewModel(
                    dashboardDefinition,
                    userDashboard)
                );
        }
    }
}