using Abp.AutoMapper;
using Afonsoft.Ranking.MultiTenancy.Dto;

namespace Afonsoft.Ranking.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(RegisterTenantOutput))]
    public class TenantRegisterResultViewModel : RegisterTenantOutput
    {
        public string TenantLoginAddress { get; set; }
    }
}