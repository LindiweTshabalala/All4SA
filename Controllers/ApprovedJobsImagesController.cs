using Microsoft.AspNetCore.Mvc;

namespace All4SA.Controllers
{
    [ApiController]
    [Route("ApprovedJobsImages")]
    public class ApprovedJobsImagesController : Controller
    {
        [HttpGet(Name = "GetAllApprovedJobsImages")]
        public IActionResult GetAllApprovedJobsImages()
        {
            return new ObjectResult("");
        }
    }
}
