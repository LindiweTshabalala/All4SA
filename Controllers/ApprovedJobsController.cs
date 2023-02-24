using Microsoft.AspNetCore.Mvc;

namespace All4SA.Controllers
{
    [ApiController]
    [Route("ApprovedJobs")]
    public class ApprovedJobsController : Controller
    {
        [HttpGet(Name = "GetAllApprovedJobss")]
        public IActionResult GetAllApprovedJobss()
        {
            return new ObjectResult("");
        }

        [HttpGet("GetApprovedJobByID/{jobID}", Name = "GetApprovedJobsByID")]
        public IActionResult GetApprovedJobsByID(int jobID)
        {
            return new ObjectResult("");
        }

        [HttpPost("AddApprovedJob", Name = "AddApprovedJob")]
        public IActionResult AddApprovedJob(int jobRequestID, int userID, int statusID)
        {
            return new ObjectResult("");
        }

        [HttpPut("UpdateApprovedJob/{jobID}", Name = "UpdateApprovedJob")]
        public IActionResult UpdateApprovedJob(int jobID, int jobRequestID, int userID, int statusID)
        {
            return new ObjectResult("");
        }

        [HttpPut("SoftDeleteApprovedJob/{jobID}", Name = "SoftDeleteApprovedJob")]
        public IActionResult SoftDeleteApprovedJob(int jobID)
        {
            return new ObjectResult("");
        }

        [HttpDelete("DeleteApprovedJob/{jobID}", Name = "ApprovedJob")]
        public IActionResult DeleteApprovedJob(int jobID)
        {
            return new ObjectResult("");
        }
    }
}
