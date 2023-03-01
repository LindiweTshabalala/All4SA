using All4SA.CRUD;
using Microsoft.AspNetCore.Mvc;


namespace All4SA.Controllers
{

    [ApiController]
    [Route("JobsApprovedDetails")]
    public class JobsApprovedDetailsController
    {


        [HttpGet(Name = "GetAllJobsApprovedDetailsCRUD")]
        public IActionResult GetAllJobsApprovedDetails()
        {
            return new ObjectResult(JobsApprovedDetailsCRUD.GetAll());
        }



        //[HttpGet("GetJobRequestDetailsByID/{jobRequestID}", Name = "GetJobRequestDetailsByID")]
        //public IActionResult GetJobRequestDetailsByID(int jobRequestID)
        //{
        //    return new ObjectResult(JobRequestDetailsCRUD.GetByID(jobRequestID));
        //}
    }
}
