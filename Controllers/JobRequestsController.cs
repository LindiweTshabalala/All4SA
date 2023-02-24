using Microsoft.AspNetCore.Mvc;

namespace All4SA.Controllers
{
    [ApiController]
    [Route("JobRequests")]
    public class JobRequestsController : Controller
    {
        [HttpGet(Name = "GetAllJobRequests")]
        public IActionResult GetAllJobRequests()
        {
            return new ObjectResult("");
        }

        [HttpGet("GetJobRequestByID/{jobRequestID}", Name = "GetJobRequestByID")]
        public IActionResult GetJobRequestByID(int jobRequestID)
        {
            return new ObjectResult("");
        }

        [HttpPost("AddJobRequest", Name = "AddJobRequest")]
        public IActionResult AddJobRequest(string jobRequestDescription, int UserID, int imageReferenceID, string jobTypeID, int estimatedCost)
        {
            return new ObjectResult("");
        }

        [HttpPut("UpdateJobRequest/{jobRequestID}", Name = "UpdateJobRequest")]
        public IActionResult UpdateJobRequest(int jobRequestID, string jobRequestDescription, int UserID, int imageReferenceID, string jobTypeID, int estimatedCost)
        {
            return new ObjectResult("");
        }

        [HttpPut("SoftDeleteJobRequest/{jobRequestID}", Name = "SoftDeleteJobRequest")]
        public IActionResult SoftDeleteJobRequest(int jobRequestID)
        {
            return new ObjectResult("");
        }

        [HttpDelete("DeleteJobRequest/{jobRequestID}", Name = "DeleteJobRequest")]
        public IActionResult DeleteJobRequest(int jobRequestID)
        {
            return new ObjectResult("");
        }
    }
}
