
using System.Web.Mvc;

namespace VastraIndiaWebAPI.Controllers
{
    public class EmptyController : Controller
    {
        // GET: Empty
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}