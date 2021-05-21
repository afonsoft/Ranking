using System.Collections.Generic;
using Afonsoft.Ranking.Editions.Dto;

namespace Afonsoft.Ranking.Web.Areas.App.Models.Tenants
{
    public class TenantIndexViewModel
    {
        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }
    }
}