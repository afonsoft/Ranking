using System.Collections.Generic;
using Afonsoft.Ranking.Authorization.Permissions.Dto;

namespace Afonsoft.Ranking.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}