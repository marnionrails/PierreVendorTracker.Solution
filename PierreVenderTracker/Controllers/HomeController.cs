using Microsoft.AspNetCore.Mvc;

namespace PierreVenderTracker.Controllers
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