using System.Globalization;

namespace Afonsoft.Ranking.Localization
{
    public interface IApplicationCulturesProvider
    {
        CultureInfo[] GetAllCultures();
    }
}