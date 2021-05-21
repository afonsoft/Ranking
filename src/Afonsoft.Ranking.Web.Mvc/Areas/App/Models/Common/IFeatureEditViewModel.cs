using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Afonsoft.Ranking.Editions.Dto;

namespace Afonsoft.Ranking.Web.Areas.App.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}