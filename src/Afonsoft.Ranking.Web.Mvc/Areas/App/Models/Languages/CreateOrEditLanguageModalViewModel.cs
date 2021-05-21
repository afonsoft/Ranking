using Abp.AutoMapper;
using Afonsoft.Ranking.Localization.Dto;

namespace Afonsoft.Ranking.Web.Areas.App.Models.Languages
{
    [AutoMapFrom(typeof(GetLanguageForEditOutput))]
    public class CreateOrEditLanguageModalViewModel : GetLanguageForEditOutput
    {
        public bool IsEditMode => Language.Id.HasValue;
    }
}