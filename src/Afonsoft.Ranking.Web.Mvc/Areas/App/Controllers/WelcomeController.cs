using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Afonsoft.Ranking.Web.Controllers;

namespace Afonsoft.Ranking.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize]
    public class WelcomeController : RankingControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}