using Abp.Auditing;
using Afonsoft.Ranking.Configuration.Dto;

namespace Afonsoft.Ranking.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}