using System.Collections.Generic;
using Afonsoft.Ranking.DashboardCustomization.Dto;

namespace Afonsoft.Ranking.Web.Areas.App.Models.CustomizableDashboard
{
    public class AddWidgetViewModel
    {
        public List<WidgetOutput> Widgets { get; set; }

        public string DashboardName { get; set; }

        public string PageId { get; set; }
    }
}
