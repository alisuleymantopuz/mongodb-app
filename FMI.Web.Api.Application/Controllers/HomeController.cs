using System.Web.Mvc;

namespace FMI.Web.Api.Application.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
