using Abp.Dependency;
using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afonsoft.Ranking.Championships
{
    public class ChampionshipsManager : RankingDomainServiceBase, IChampionshipsManager
    {
        public Task<List<CalendarChampionship>> GetCalendars(int tenantId, long ChampionshipId)
        {
            throw new NotImplementedException();
        }

        public Task<Championship> GetChampionship(int tenantId, long ChampionshipId)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetRoles(int tenantId, long ChampionshipId)
        {
            throw new NotImplementedException();
        }

        public Task InsertRoles(RoleChampionship role)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRoles(RoleChampionship role)
        {
            throw new NotImplementedException();
        }
    }
}