using Microsoft.AspNetCore.Mvc;

namespace All4SA.Controllers
{
    public class StatusesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
