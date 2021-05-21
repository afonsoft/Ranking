using System.Threading.Tasks;
using Abp.Application.Services;
using Afonsoft.Ranking.Configuration.Tenants.Dto;

namespace Afonsoft.Ranking.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
