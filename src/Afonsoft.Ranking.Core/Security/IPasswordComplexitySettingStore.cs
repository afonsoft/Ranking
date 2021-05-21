using System.Threading.Tasks;

namespace Afonsoft.Ranking.Security
{
    public interface IPasswordComplexitySettingStore
    {
        Task<PasswordComplexitySetting> GetSettingsAsync();
    }
}
