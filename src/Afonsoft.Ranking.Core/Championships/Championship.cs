using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.MultiTenancy;
using Afonsoft.Ranking.MultiTenancy;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afonsoft.Ranking.Championships
{
    [MultiTenancySide(MultiTenancySides.Tenant)]
    [Table("AbpChampionship")]
    public class Championship : FullAuditedEntity<long>, IMustHaveTenant
    {
        public int TenantId { get; set; }
        public long? RoleId { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }

        public string Name { get; set; }
        public bool Active { get; set; }

        [ForeignKey("RoleId")]
        public virtual RoleChampionship Role { get; set; }

        [ForeignKey("TenantId")]
        public virtual Tenant Group { get; set; }

        public virtual ICollection<CalendarChampionship> CalendarChampionships { get; set; }

        public virtual ICollection<TeamChampionship> TeamChampionships { get; set; }
    }
}