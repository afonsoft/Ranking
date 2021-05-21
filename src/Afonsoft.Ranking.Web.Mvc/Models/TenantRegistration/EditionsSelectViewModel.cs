using Abp.AutoMapper;
using Afonsoft.Ranking.MultiTenancy.Dto;

namespace Afonsoft.Ranking.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(EditionsSelectOutput))]
    public class EditionsSelectViewModel : EditionsSelectOutput
    {
    }
}
