using System.ComponentModel.DataAnnotations;

namespace Afonsoft.Ranking.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}