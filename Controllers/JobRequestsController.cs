using Microsoft.AspNetCore.Mvc;

namespace All4SA.Controllers
{
    [ApiController]
    [Route("JobRequests")]
    public class JobRequestsController : Controller
    {
        [HttpGet(Name = "GetAllJobRequests")]
        public IActionResult Index()
        {
            return new ObjectResult("");
        }
    }
}
