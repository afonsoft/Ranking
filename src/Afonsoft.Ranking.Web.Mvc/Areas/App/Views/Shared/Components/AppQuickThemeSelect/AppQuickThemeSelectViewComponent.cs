using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Afonsoft.Ranking.Web.Areas.App.Models.Layout;
using Afonsoft.Ranking.Web.Views;

namespace Afonsoft.Ranking.Web.Areas.App.Views.Shared.Components.
    AppQuickThemeSelect
{
    public class AppQuickThemeSelectViewComponent : RankingViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(string cssClass)
        {
            return Task.FromResult<IViewComponentResult>(View(new QuickThemeSelectionViewModel
            {
                CssClass = cssClass
            }));
        }
    }
}
