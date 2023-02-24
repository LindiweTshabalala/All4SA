using Microsoft.AspNetCore.Mvc;

namespace All4SA.Controllers
{
    public class PublicVotesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
