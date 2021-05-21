using System.ComponentModel.DataAnnotations;

namespace Afonsoft.Ranking.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}