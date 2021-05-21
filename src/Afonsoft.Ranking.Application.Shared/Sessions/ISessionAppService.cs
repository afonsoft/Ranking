using System.Threading.Tasks;
using Abp.Application.Services;
using Afonsoft.Ranking.Sessions.Dto;

namespace Afonsoft.Ranking.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
