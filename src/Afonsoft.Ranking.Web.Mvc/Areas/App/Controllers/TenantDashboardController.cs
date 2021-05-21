using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Afonsoft.Ranking.Authorization;
using Afonsoft.Ranking.DashboardCustomization;
using System.Threading.Tasks;
using Afonsoft.Ranking.Web.Areas.App.Startup;

namespace Afonsoft.Ranking.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize(AppPermissions.Pages_Tenant_Dashboard)]
    public class TenantDashboardController : CustomizableDashboardControllerBase
    {
        public TenantDashboardController(DashboardViewConfiguration dashboardViewConfiguration, 
            IDashboardCustomizationAppService dashboardCustomizationAppService) 
            : base(dashboardViewConfiguration, dashboardCustomizationAppService)
        {

        }

        public async Task<ActionResult> Index()
        {
            return await GetView(RankingDashboardCustomizationConsts.DashboardNames.DefaultTenantDashboard);
        }
    }
}