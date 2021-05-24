using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.MultiTenancy;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afonsoft.Ranking.Championships
{
    [MultiTenancySide(MultiTenancySides.Tenant)]
    [Table("AbpRoleChampionship")]
    public class RoleChampionship : FullAuditedEntity<long>, IMustHaveTenant
    {
        public int TenantId { get; set; }
        public long ChampionshipId { get; set; }
        public string RoleDescription { get; set; }

        [ForeignKey("ChampionshipId")]
        public virtual Championship Championship { get; set; }
    }
}