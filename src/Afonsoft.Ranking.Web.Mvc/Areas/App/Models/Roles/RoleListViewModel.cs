﻿using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Afonsoft.Ranking.Authorization.Permissions.Dto;
using Afonsoft.Ranking.Web.Areas.App.Models.Common;

namespace Afonsoft.Ranking.Web.Areas.App.Models.Roles
{
    public class RoleListViewModel : IPermissionsEditViewModel
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}