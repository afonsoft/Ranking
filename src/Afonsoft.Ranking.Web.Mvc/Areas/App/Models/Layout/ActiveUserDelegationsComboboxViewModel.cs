using System.Collections.Generic;
using Afonsoft.Ranking.Authorization.Delegation;
using Afonsoft.Ranking.Authorization.Users.Delegation.Dto;

namespace Afonsoft.Ranking.Web.Areas.App.Models.Layout
{
    public class ActiveUserDelegationsComboboxViewModel
    {
        public IUserDelegationConfiguration UserDelegationConfiguration { get; set; }
        
        public List<UserDelegationDto> UserDelegations { get; set; }
    }
}
