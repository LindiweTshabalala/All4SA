using Microsoft.AspNetCore.Mvc;

namespace All4SA.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
