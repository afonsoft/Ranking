using System.Collections.Generic;
using Afonsoft.Ranking.Caching.Dto;

namespace Afonsoft.Ranking.Web.Areas.App.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}