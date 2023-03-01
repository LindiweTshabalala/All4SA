using All4SA.CRUD;
using All4SA.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;

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
        public IActionResult createJobRequest(JobRequestDetailsDTO jobRequestDetailsDTO)
        {

            ImageReference imageReference = new ImageReference
            {
                imageReference = jobRequestDetailsDTO.ImageReferenceID,
                imageReferenceID = 0
            };

            int id = (int) ImagesReferencesCRUD.InsertEntry(imageReference);

            JobRequest jobRequest = new JobRequest
            {
                UserID = jobRequestDetailsDTO.UserID,
                EstimatedCost = jobRequestDetailsDTO.EstimatedCost,
                JobRequestDescription = jobRequestDetailsDTO.JobRequestDescription,
                JobRequestID = jobRequestDetailsDTO.JobRequestID,
                JobTypeID = jobRequestDetailsDTO.JobTypeID,
                Status = jobRequestDetailsDTO.Status,
                ImageReferenceID = id
            }; 

            return new ObjectResult(JobRequestsCRUD.InsertEntry(jobRequest));
        }
    }
}
