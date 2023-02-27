using All4SA.Models;
using Microsoft.AspNetCore.Mvc;

namespace All4SA.Controllers
{
    [ApiController]
    [Route("ApprovedJobs")]
    public class ApprovedJobsController : Controller
    {
        [HttpGet(Name = "GetAllApprovedJobs")]
        public IActionResult GetAllApprovedJobs()
        {
            return new ObjectResult("");
        }

        [HttpGet("GetApprovedJobByID/{jobID}", Name = "GetApprovedJobByID")]
        public IActionResult GetApprovedJobByID(int jobID)
        {
            return new ObjectResult("");
        }

        [HttpPost("AddApprovedJob", Name = "AddApprovedJob")]
        public IActionResult AddApprovedJob(ApprovedJobRequest approvedJob)
        {
            return new ObjectResult("");
        }

        [HttpPut("UpdateApprovedJob/{jobID}", Name = "UpdateApprovedJob")]
        public IActionResult UpdateApprovedJob(ApprovedJobRequest approvedJob)
        {
            return new ObjectResult("");
        }

        [HttpPut("SoftDeleteApprovedJob/{jobID}", Name = "SoftDeleteApprovedJob")]
        public IActionResult SoftDeleteApprovedJob(int jobID)
        {
            return new ObjectResult("");
        }

        [HttpDelete("DeleteApprovedJob/{jobID}", Name = "DeleteApprovedJob")]
        public IActionResult DeleteApprovedJob(int jobID)
        {
            return new ObjectResult("");
        }
    }
}
