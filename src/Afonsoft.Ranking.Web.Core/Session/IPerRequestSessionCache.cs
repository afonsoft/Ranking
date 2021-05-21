using System.Threading.Tasks;
using Afonsoft.Ranking.Sessions.Dto;

namespace Afonsoft.Ranking.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
