using System.Threading.Tasks;
using Abp.Webhooks;

namespace Afonsoft.Ranking.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
