using System.Threading.Tasks;

namespace Afonsoft.Ranking.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}