using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using Afonsoft.Ranking.Authorization.Users;
using Afonsoft.Ranking.MultiTenancy;

namespace Afonsoft.Ranking.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}