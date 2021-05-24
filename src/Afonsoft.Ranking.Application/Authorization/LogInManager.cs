using Abp.Authorization;
using Abp.Authorization.Users;
using Abp.Configuration;
using Abp.Configuration.Startup;
using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.Zero.Configuration;
using Microsoft.AspNetCore.Identity;
using Afonsoft.Ranking.Authorization.Roles;
using Afonsoft.Ranking.Authorization.Users;
using Afonsoft.Ranking.MultiTenancy;
using System.Threading.Tasks;
using Abp.Extensions;
using System;

namespace Afonsoft.Ranking.Authorization
{
    public class LogInManager : AbpLogInManager<Tenant, Role, User>
    {
        private readonly UserStore _userStore;

        public LogInManager(
            UserManager userManager,
            IMultiTenancyConfig multiTenancyConfig,
            IRepository<Tenant> tenantRepository,
            IUnitOfWorkManager unitOfWorkManager,
            ISettingManager settingManager,
            IRepository<UserLoginAttempt, long> userLoginAttemptRepository,
            IUserManagementConfig userManagementConfig,
            IIocResolver iocResolver,
            RoleManager roleManager,
            IPasswordHasher<User> passwordHasher,
            UserClaimsPrincipalFactory claimsPrincipalFactory,
            UserStore userStore)
            : base(
                  userManager,
                  multiTenancyConfig,
                  tenantRepository,
                  unitOfWorkManager,
                  settingManager,
                  userLoginAttemptRepository,
                  userManagementConfig,
                  iocResolver,
                  passwordHasher,
                  roleManager,
                  claimsPrincipalFactory)
        {
            _userStore = userStore;
        }

        [UnitOfWork]
        public async Task<AbpLoginResult<Tenant, User>> LoginAsync(UserLoginInfo login)
        {
            var result = await LoginAsyncInternal(login);
            await SaveLoginAttemptAsync(result, result.Tenant.Name, login.ProviderKey + "@" + login.LoginProvider);
            return result;
        }

        protected async Task<AbpLoginResult<Tenant, User>> LoginAsyncInternal(UserLoginInfo login)
        {
            if (login == null || login.LoginProvider.IsNullOrEmpty() || login.ProviderKey.IsNullOrEmpty())
            {
                throw new ArgumentException("login");
            }
            using (UnitOfWorkManager.Current.DisableFilter(AbpDataFilters.MayHaveTenant))
            {
                var user = await _userStore.FindAsync(login);
                if (user == null)
                {
                    return new AbpLoginResult<Tenant, User>(AbpLoginResultType.UnknownExternalLogin);
                }
                //Get and check tenant
                Tenant tenant = null;
                if (!MultiTenancyConfig.IsEnabled)
                {
                    tenant = await GetDefaultTenantAsync();
                }
                else if (user.TenantId.HasValue)
                {
                    tenant = await TenantRepository.FirstOrDefaultAsync(t => t.Id == user.TenantId);
                    if (tenant == null)
                    {
                        return new AbpLoginResult<Tenant, User>(AbpLoginResultType.InvalidTenancyName);
                    }
                    if (!tenant.IsActive)
                    {
                        return new AbpLoginResult<Tenant, User>(AbpLoginResultType.TenantIsNotActive, tenant);
                    }
                }
                return await CreateLoginResultAsync(user, tenant);
            }
        }
    }
}