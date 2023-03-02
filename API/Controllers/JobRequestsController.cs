using All4SA.CRUD;
using All4SA.Models;
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
            return new ObjectResult(JobRequestsCRUD.GetAll());
        }


        [HttpGet("GetJobRequestByID/{jobRequestID}", Name = "GetJobRequestByID")]
        public IActionResult GetJobRequestByID(int jobRequestID)
        {
            try
            {
                JobRequest? job = JobRequestsCRUD.GetByID(jobRequestID);

                ObjectResult objectResult = new ObjectResult(job);

                if (job == null)
                {
                    objectResult.StatusCode = 404;
                    return objectResult;
                }
                return objectResult;
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        [HttpPost("AddJobRequest", Name = "AddJobRequest")]
        public IActionResult AddJobRequest(JobRequest jobRequest)
        {
            try
            {
                return new ObjectResult(JobRequestsCRUD.InsertEntry(jobRequest));
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
