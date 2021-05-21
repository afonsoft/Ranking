using System.Collections.Generic;
using Afonsoft.Ranking.Authorization.Users.Dto;

namespace Afonsoft.Ranking.Web.Areas.App.Models.Users
{
    public class UserLoginAttemptModalViewModel
    {
        public List<UserLoginAttemptDto> LoginAttempts { get; set; }
    }
}