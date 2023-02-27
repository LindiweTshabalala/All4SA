using All4SA.Models;
using Microsoft.AspNetCore.Mvc;

namespace All4SA.Controllers
{
    [ApiController]
    [Route("JobsImagesReferences")]
    public class JobsImagesReferencesController : Controller
    {
        [HttpGet(Name = "GetAllJobsImagesReferences")]
        public IActionResult GetAllJobsImagesReferences()
        {
            return new ObjectResult("");
        }

        [HttpGet("GetJobsImageReferenceByID/{jobsImageReferenceID}", Name = "JobsImageReferenceByID")]
        public IActionResult GetJobsImageReferenceReferenceByID(int jobsImageReferenceID)
        {
            return new ObjectResult("");
        }

        [HttpPost("AddJobsImageReference", Name = "AddJobsImageReference")]
        public IActionResult AddJobsImageReferenceReference(ApprovedJobsImage approvedJobsImage)
        {
            return new ObjectResult("");
        }

        [HttpPut("UpdateJobsImageReference/{jobsImageReferenceID}", Name = "UpdateJobsImageReference")]
        public IActionResult UpdateJobsImagesReference(ApprovedJobsImage approvedJobsImage)
        {
            return new ObjectResult("");
        }

        [HttpPut("SoftDeleteJobsImageReference/{jobsImageReferenceID}", Name = "SoftDeleteJobsImageReference")]
        public IActionResult SoftDeleteJobsImageReference(int jobsImageReferenceID)
        {
            return new ObjectResult("");
        }

        [HttpDelete("DeleteJobsImageReference/{jobsImageReferenceID}", Name = "JobsImageReference")]
        public IActionResult DeleteJobsImageReference(int jobsImageReferenceID)
        {
            return new ObjectResult("");
        }
    }
}
