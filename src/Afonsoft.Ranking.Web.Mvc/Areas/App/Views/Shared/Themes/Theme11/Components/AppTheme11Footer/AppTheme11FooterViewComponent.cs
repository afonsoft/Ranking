using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Afonsoft.Ranking.Web.Areas.App.Models.Layout;
using Afonsoft.Ranking.Web.Session;
using Afonsoft.Ranking.Web.Views;

namespace Afonsoft.Ranking.Web.Areas.App.Views.Shared.Themes.Theme11.Components.AppTheme11Footer
{
    public class AppTheme11FooterViewComponent : RankingViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppTheme11FooterViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerModel = new FooterViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(footerModel);
        }
    }
}
