using Microsoft.AspNetCore.Mvc;

namespace All4SA.Controllers
{
    [ApiController]
    [Route("Statuses")]
    public class StatusesController : Controller
    {
        [HttpGet(Name = "GetAllStatuses")]
        public IActionResult Index()
        {
            return new ObjectResult("");
        }
    }
}
