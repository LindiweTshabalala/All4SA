using All4SA.CRUD;
using All4SA.Models;
using Microsoft.AspNetCore.Mvc;

namespace All4SA.Controllers
{
    [ApiController]
    [Route("JobTypes")]
    public class JobTypesController : Controller
    {
        [HttpGet(Name = "GetAllJobTypes")]
        public IActionResult GetAllJobTypes()
        {
            return new ObjectResult(JobTypesCRUD.GetAll());
        }

        [HttpGet("GetJobTypeByID/{jobTypeID}", Name = "GetJobTypeByID")]
        public IActionResult GetJobTypeByID(int jobTypeID)
        {
            return new ObjectResult("");
        }

        [HttpPost("AddJobType", Name = "AddJobType")]
        public IActionResult AddJobType(JobType jobType)
        {
            return new ObjectResult("");
        }

        [HttpPut("UpdateJobType/{jobTypeID}", Name = "UpdateJobType")]
        public IActionResult UpdateJobType(JobType jobType)
        {
            return new ObjectResult("");
        }

        [HttpPut("SoftDeleteJobType/{jobTypeID}", Name = "SoftDeleteJobType")]
        public IActionResult SoftDeleteJobType(int jobTypeID)
        {
            return new ObjectResult("");
        }

        [HttpDelete("DeleteJobType/{jobTypeID}", Name = "DeleteJobType")]
        public IActionResult DeleteJobType(int jobTypeID)
        {
            return new ObjectResult("");
        }
    }
}
