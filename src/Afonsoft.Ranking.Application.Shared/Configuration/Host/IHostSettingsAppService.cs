using System.Threading.Tasks;
using Abp.Application.Services;
using Afonsoft.Ranking.Configuration.Host.Dto;

namespace Afonsoft.Ranking.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
