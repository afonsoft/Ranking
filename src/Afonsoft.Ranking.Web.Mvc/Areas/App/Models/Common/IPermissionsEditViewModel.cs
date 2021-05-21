using System.Collections.Generic;
using Afonsoft.Ranking.Authorization.Permissions.Dto;

namespace Afonsoft.Ranking.Web.Areas.App.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}