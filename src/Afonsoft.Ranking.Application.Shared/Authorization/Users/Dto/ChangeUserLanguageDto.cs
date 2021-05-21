using System.ComponentModel.DataAnnotations;

namespace Afonsoft.Ranking.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
