using System.Web.Mvc;

namespace AppSample.Controllers
{
    public class HomeController : Controller
    {        
        public ActionResult Index()
        {
            return RedirectToRoute("Page 0");
        }
    }
}