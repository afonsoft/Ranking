using Abp.Domain.Repositories;
using Afonsoft.Ranking.MultiTenancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Afonsoft.Ranking.Web.Resources
{
    public class TenantDatabase
    {
        private readonly IRepository<Tenant> _tenantRepository;

        public TenantDatabase(IRepository<Tenant> tenantRepository)
        {
            _tenantRepository = tenantRepository;
        }

        public int? Resolve(string tenant)
        {
            if (string.IsNullOrEmpty(tenant))
                return null;

            var normalizedTenent = tenant.ToLowerInvariant();

            var te = _tenantRepository.GetAll()
                                    .FirstOrDefault(x => x.Id.ToString() == normalizedTenent
                                                    || x.Name.ToLowerInvariant() == normalizedTenent
                                                    || x.TenancyName.ToLowerInvariant() == normalizedTenent);
            if (te == null)
                return null;

            return te.Id;
        }
    }
}