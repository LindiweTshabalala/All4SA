using Microsoft.AspNetCore.Mvc;

namespace All4SA.Controllers
{
    public class JobRequestsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
