using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using Afonsoft.Ranking.Dto;

namespace Afonsoft.Ranking.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
