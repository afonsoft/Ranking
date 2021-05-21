using System.Threading.Tasks;
using Afonsoft.Ranking.Authorization.Users;

namespace Afonsoft.Ranking.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
