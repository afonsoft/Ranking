using Abp.AutoMapper;
using Afonsoft.Ranking.Authorization.Roles.Dto;
using Afonsoft.Ranking.Web.Areas.App.Models.Common;

namespace Afonsoft.Ranking.Web.Areas.App.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class CreateOrEditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool IsEditMode => Role.Id.HasValue;
    }
}