using System.Collections.Generic;
using Afonsoft.Ranking.Editions.Dto;
using Afonsoft.Ranking.Security;

namespace Afonsoft.Ranking.Web.Areas.App.Models.Tenants
{
    public class CreateTenantViewModel
    {
        public IReadOnlyList<SubscribableEditionComboboxItemDto> EditionItems { get; set; }

        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public CreateTenantViewModel(IReadOnlyList<SubscribableEditionComboboxItemDto> editionItems)
        {
            EditionItems = editionItems;
        }
    }
}