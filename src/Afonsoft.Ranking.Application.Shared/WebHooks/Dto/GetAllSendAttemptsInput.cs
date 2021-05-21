using Afonsoft.Ranking.Dto;

namespace Afonsoft.Ranking.WebHooks.Dto
{
    public class GetAllSendAttemptsInput : PagedInputDto
    {
        public string SubscriptionId { get; set; }
    }
}
