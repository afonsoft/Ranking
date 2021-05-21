using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Afonsoft.Ranking.Web.Areas.App.Models.Layout;
using Afonsoft.Ranking.Web.Session;
using Afonsoft.Ranking.Web.Views;

namespace Afonsoft.Ranking.Web.Areas.App.Views.Shared.Themes.Theme8.Components.AppTheme8Brand
{
    public class AppTheme8BrandViewComponent : RankingViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppTheme8BrandViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var headerModel = new HeaderViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(headerModel);
        }
    }
}
