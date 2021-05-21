using Abp.AutoMapper;
using Afonsoft.Ranking.Sessions.Dto;

namespace Afonsoft.Ranking.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}