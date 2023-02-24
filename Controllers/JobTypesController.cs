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
            return new ObjectResult("");
        }

        [HttpGet("GetJobTypeByID/{jobTypeID}", Name = "GetJobTypeByID")]
        public IActionResult GetJobTypeByID(int jobTypeID)
        {
            return new ObjectResult("");
        }

        [HttpPost("AddJobType", Name = "AddJobType")]
        public IActionResult AddJobType(string jobTypeName, int hourlyRate)
        {
            return new ObjectResult("");
        }

        [HttpPut("UpdateJobType/{jobTypeID}", Name = "UpdateJobType")]
        public IActionResult UpdateJobType(int jobTypeID, string jobTypeName, int hourlyRate)
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
