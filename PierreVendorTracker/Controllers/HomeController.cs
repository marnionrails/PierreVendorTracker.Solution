using Microsoft.AspNetCore.Mvc;

namespace PierreVendorTracker.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
    }
}