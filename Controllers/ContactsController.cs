using Microsoft.AspNetCore.Mvc;

namespace All4SA.Controllers
{
    [ApiController]
    [Route("Contacts")]
    public class ContactsController : Controller
    {
        [HttpGet(Name = "GetAllContacts")]
        public IActionResult Index()
        {
            return new ObjectResult("");
        }
    }
}
