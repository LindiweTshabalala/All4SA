using Microsoft.AspNetCore.Mvc;

namespace All4SA.Controllers
{
    [ApiController]
    [Route("ApprovedJobRequests")]
    public class ApprovedJobRequestsController : Controller
    {
        [HttpGet(Name = "GetAllApprovedJobRequests")]
        public IActionResult GetAllApprovedJobRequests()
        {
            return new ObjectResult("");
        }
    }
}
