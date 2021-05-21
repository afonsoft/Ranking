using System.Collections.Generic;
using Abp.Localization;
using Afonsoft.Ranking.Install.Dto;

namespace Afonsoft.Ranking.Web.Models.Install
{
    public class InstallViewModel
    {
        public List<ApplicationLanguage> Languages { get; set; }

        public AppSettingsJsonDto AppSettingsJson { get; set; }
    }
}
