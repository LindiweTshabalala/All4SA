using Microsoft.AspNetCore.Mvc;

namespace All4SA.Controllers
{
    public class ApprovedJobRequestsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
