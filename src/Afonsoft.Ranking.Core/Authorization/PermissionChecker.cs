using Abp.Authorization;
using Afonsoft.Ranking.Authorization.Roles;
using Afonsoft.Ranking.Authorization.Users;

namespace Afonsoft.Ranking.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
