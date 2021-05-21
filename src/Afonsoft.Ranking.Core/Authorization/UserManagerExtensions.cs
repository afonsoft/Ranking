using System.Threading.Tasks;
using Abp.Authorization.Users;
using Afonsoft.Ranking.Authorization.Users;

namespace Afonsoft.Ranking.Authorization
{
    public static class UserManagerExtensions
    {
        public static async Task<User> GetAdminAsync(this UserManager userManager)
        {
            return await userManager.FindByNameAsync(AbpUserBase.AdminUserName);
        }
    }
}
