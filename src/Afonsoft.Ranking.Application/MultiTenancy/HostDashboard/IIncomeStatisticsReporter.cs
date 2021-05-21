using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Afonsoft.Ranking.MultiTenancy.HostDashboard.Dto;

namespace Afonsoft.Ranking.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}