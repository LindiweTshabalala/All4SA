using All4SA.CRUD;
using All4SA.Models;
using Microsoft.AspNetCore.Mvc;


namespace All4SA.Controllers
{
    [ApiController]
    [Route("JobRequestDetails")]
    public class JobRequestDetailsController : Controller
    {


        [HttpGet(Name = "GetAllJobRequestDetails")]
        public IActionResult getAllJobRequestDetails()
        {
            return new ObjectResult(JobRequestDetailsCRUD.GetAll());
        }


        [HttpGet("GetJobRequestDetailsByID/{jobRequestID}", Name = "GetJobRequestDetailsByID")]
        public IActionResult getJobRequestDetailsByID(int jobRequestID)
        {
            return new ObjectResult(JobRequestDetailsCRUD.GetByID(jobRequestID));
        }

        [HttpPost("create", Name = "CreateJobRequestDetail")]
        public IActionResult createJobRequest(JobRequestDetails jobRequestDetails)
        {
            return new ObjectResult(jobRequestDetails);
        }
    }
}
