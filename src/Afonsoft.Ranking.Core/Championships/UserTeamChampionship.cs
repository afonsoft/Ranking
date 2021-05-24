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
    [Table("AbpUserTeamChampionship")]
    public class UserTeamChampionship : FullAuditedEntity<long>, IMustHaveTenant
    {
        public int TenantId { get; set; }
        public long TeamId { get; set; }
        public long UserId { get; set; }
        public bool Active { get; set; }

        [ForeignKey("TeamId")]
        public virtual TeamChampionship TeamChampionship { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public virtual ICollection<CalendarResult> CalendarResults { get; set; }
    }
}