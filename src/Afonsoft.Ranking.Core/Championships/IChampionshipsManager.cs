using Abp.Authorization;
using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afonsoft.Ranking.Championships
{
    public interface IChampionshipsManager : IDomainService
    {
        public Task<string> GetRoles(int tenantId, long ChampionshipId);

        [AbpAuthorize]
        public Task UpdateRoles(RoleChampionship role);

        [AbpAuthorize]
        public Task InsertRoles(RoleChampionship role);

        public Task<Championship> GetChampionship(int tenantId, long ChampionshipId);

        public Task<List<CalendarChampionship>> GetCalendars(int tenantId, long ChampionshipId);
    }
}