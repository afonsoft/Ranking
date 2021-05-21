using Abp.Application.Services.Dto;
using Abp.Webhooks;
using Afonsoft.Ranking.WebHooks.Dto;

namespace Afonsoft.Ranking.Web.Areas.App.Models.Webhooks
{
    public class CreateOrEditWebhookSubscriptionViewModel
    {
        public WebhookSubscription WebhookSubscription { get; set; }

        public ListResultDto<GetAllAvailableWebhooksOutput> AvailableWebhookEvents { get; set; }
    }
}
