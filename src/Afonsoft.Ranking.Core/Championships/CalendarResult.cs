using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.MultiTenancy;
using Afonsoft.Ranking.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afonsoft.Ranking.Championships
{
    [MultiTenancySide(MultiTenancySides.Tenant)]
    [Table("AbpCalendarResult")]
    public class CalendarResult : FullAuditedEntity<long>, IMustHaveTenant
    {
        public int TenantId { get; set; }
        public long CalendarId { get; set; }
        public long? UserId { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
        public int Milliseconds { get; set; }

        public int Position { get; set; }

        public int Points { get; set; }

        public int Laps { get; set; }

        [ForeignKey("CalendarId")]
        public virtual CalendarChampionship CalendarChampionship { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}