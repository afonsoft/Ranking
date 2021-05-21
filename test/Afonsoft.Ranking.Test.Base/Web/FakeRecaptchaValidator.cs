using System.Threading.Tasks;
using Afonsoft.Ranking.Security.Recaptcha;

namespace Afonsoft.Ranking.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
