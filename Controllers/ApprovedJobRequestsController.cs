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

        [HttpGet("GetApprovedJobRequestByID/{jobID}", Name = "GetApprovedJobRequestByID")]
        public IActionResult GetApprovedJobRequestByID(int jobID)
        {
            return new ObjectResult("");
        }

        [HttpPost("AddApprovedJobRequest", Name = "AddApprovedJobRequest")]
        public IActionResult AddApprovedJobRequest(int jobRequestID, int userID, int statusID)
        {
            return new ObjectResult("");
        }

        [HttpPut("UpdateApprovedJobRequest/{jobID}", Name = "UpdateApprovedJobRequest")]
        public IActionResult UpdateApprovedJobRequest(int jobID, int jobRequestID, int userID, int statusID)
        {
            return new ObjectResult("");
        }

        [HttpPut("SoftDeleteApprovedJobRequest/{jobID}", Name = "SoftDeleteApprovedJobRequest")]
        public IActionResult SoftDeleteApprovedJobRequest(int jobID)
        {
            return new ObjectResult("");
        }

        [HttpDelete("DeleteApprovedJobRequest/{jobID}", Name = "ApprovedJobRequest")]
        public IActionResult DeleteApprovedJobRequest(int addressID)
        {
            return new ObjectResult("");
        }
    }
}
