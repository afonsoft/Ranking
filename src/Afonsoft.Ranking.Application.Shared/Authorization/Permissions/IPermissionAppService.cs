using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Afonsoft.Ranking.Authorization.Permissions.Dto;

namespace Afonsoft.Ranking.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
