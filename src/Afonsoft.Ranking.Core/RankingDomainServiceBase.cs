using Abp.Domain.Services;

namespace Afonsoft.Ranking
{
    public abstract class RankingDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected RankingDomainServiceBase()
        {
            LocalizationSourceName = RankingConsts.LocalizationSourceName;
        }
    }
}
