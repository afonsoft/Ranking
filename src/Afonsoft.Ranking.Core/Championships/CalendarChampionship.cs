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
    [Table("AbpCalendarChampionship")]
    public class CalendarChampionship : FullAuditedEntity<long>, IMustHaveTenant
    {
        public int TenantId { get; set; }

        public string Name { get; set; }

        public string Track { get; set; }

        public DateTime Schedule { get; set; }

        public string Circuit { get; set; }

        public virtual Championship Championship { get; set; }
    }
}