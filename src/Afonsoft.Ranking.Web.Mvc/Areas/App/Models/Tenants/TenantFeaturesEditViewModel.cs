using Abp.AutoMapper;
using Afonsoft.Ranking.MultiTenancy;
using Afonsoft.Ranking.MultiTenancy.Dto;
using Afonsoft.Ranking.Web.Areas.App.Models.Common;

namespace Afonsoft.Ranking.Web.Areas.App.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }
    }
}