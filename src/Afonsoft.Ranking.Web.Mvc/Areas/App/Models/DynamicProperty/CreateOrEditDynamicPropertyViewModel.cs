using System.Collections.Generic;
using Afonsoft.Ranking.DynamicEntityProperties.Dto;

namespace Afonsoft.Ranking.Web.Areas.App.Models.DynamicProperty
{
    public class CreateOrEditDynamicPropertyViewModel
    {
        public DynamicPropertyDto DynamicPropertyDto { get; set; }

        public List<string> AllowedInputTypes { get; set; }
    }
}
