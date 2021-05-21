using Abp.Application.Services;
using Afonsoft.Ranking.Dto;
using Afonsoft.Ranking.Logging.Dto;

namespace Afonsoft.Ranking.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
