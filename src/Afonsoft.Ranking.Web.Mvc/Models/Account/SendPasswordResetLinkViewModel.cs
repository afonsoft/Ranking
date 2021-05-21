using System.ComponentModel.DataAnnotations;

namespace Afonsoft.Ranking.Web.Models.Account
{
    public class SendPasswordResetLinkViewModel
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}