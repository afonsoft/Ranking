using System.Collections.Generic;
using Afonsoft.Ranking.Authorization.Permissions.Dto;

namespace Afonsoft.Ranking.Authorization.Roles.Dto
{
    public class GetRoleForEditOutput
    {
        public RoleEditDto Role { get; set; }

        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}