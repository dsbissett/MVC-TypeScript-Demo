using System.Web.Mvc;

namespace AppSample.Controllers
{
    public class SampleController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PageFactory(int id)
        {
            switch (id)
            {
                case (0):
                {
                    return PartialView("_page0");
                }
                case (1):
                {
                    return PartialView("_page1");
                }
                case (2):
                {
                    return PartialView("_page2");
                }
                case (3):
                {
                    return PartialView("_page3");
                }
                case (4):
                {
                    return PartialView("_page4");
                }
                case (5):
                {
                    return PartialView("_page5");
                }
                case (6):
                {
                    return PartialView("_page6");
                }
                case (7):
                {
                    return PartialView("_page7");
                }
                case (8):
                {
                    return PartialView("_page8");
                }
                default:
                {
                    return PartialView("Index");
                }
            }
        }
    }
}