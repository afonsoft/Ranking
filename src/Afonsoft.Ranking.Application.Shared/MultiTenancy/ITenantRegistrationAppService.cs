using System.Threading.Tasks;
using Abp.Application.Services;
using Afonsoft.Ranking.Editions.Dto;
using Afonsoft.Ranking.MultiTenancy.Dto;

namespace Afonsoft.Ranking.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}