using Abp.AspNetCore.Mvc.ViewComponents;

namespace Afonsoft.Ranking.Web.Views
{
    public abstract class RankingViewComponent : AbpViewComponent
    {
        protected RankingViewComponent()
        {
            LocalizationSourceName = RankingConsts.LocalizationSourceName;
        }
    }
}