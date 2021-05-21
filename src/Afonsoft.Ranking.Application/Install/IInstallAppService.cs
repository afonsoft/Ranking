using System.Threading.Tasks;
using Abp.Application.Services;
using Afonsoft.Ranking.Install.Dto;

namespace Afonsoft.Ranking.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}