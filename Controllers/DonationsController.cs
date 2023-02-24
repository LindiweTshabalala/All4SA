using Microsoft.AspNetCore.Mvc;

namespace All4SA.Controllers
{
    public class DonationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
