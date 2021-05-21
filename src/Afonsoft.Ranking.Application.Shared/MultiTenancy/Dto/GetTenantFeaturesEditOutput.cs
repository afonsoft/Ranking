using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Afonsoft.Ranking.Editions.Dto;

namespace Afonsoft.Ranking.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}