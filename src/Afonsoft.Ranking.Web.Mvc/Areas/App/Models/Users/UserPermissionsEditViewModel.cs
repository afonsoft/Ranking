using Abp.AutoMapper;
using Afonsoft.Ranking.Authorization.Users;
using Afonsoft.Ranking.Authorization.Users.Dto;
using Afonsoft.Ranking.Web.Areas.App.Models.Common;

namespace Afonsoft.Ranking.Web.Areas.App.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; set; }
    }
}