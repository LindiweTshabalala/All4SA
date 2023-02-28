using All4SA.CRUD;
using All4SA.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;


namespace All4SA.Controllers
{
    [ApiController]
    [Route("JobRequestDetails")]
    public class JobRequestDetailsController : Controller
    {


        [HttpGet(Name = "GetAllJobRequestDetails")]
        public IActionResult GetAllJobRequestDetails()
        {
            return new ObjectResult("");
        }



        [HttpGet("GetJobRequestDetailsByID/{jobRequestID}", Name = "GetJobRequestDetailsByID")]
        public IActionResult GetJobRequestDetailsByID(int jobRequestID)
        {
            return new ObjectResult(JobRequestDetailsCRUD.GetByID(jobRequestID));
        }
    }
}
