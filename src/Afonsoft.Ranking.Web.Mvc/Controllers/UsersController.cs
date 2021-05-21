using Abp.AspNetCore.Mvc.Authorization;
using Afonsoft.Ranking.Authorization;
using Afonsoft.Ranking.Storage;
using Abp.BackgroundJobs;
using Abp.Authorization;

namespace Afonsoft.Ranking.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}