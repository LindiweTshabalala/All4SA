using All4SA.CRUD;
using Microsoft.AspNetCore.Mvc;


namespace All4SA.Controllers
{

    [ApiController]
    [Route("JobsApprovedDetails")]
    public class JobsApprovedDetailsController: Controller
    {


        [HttpGet(Name = "GetAllJobsApprovedDetailsCRUD")]
        public IActionResult GetAllJobsApprovedDetails()
        {
            try
            {
                return new ObjectResult(JobsApprovedDetailsCRUD.GetAll());
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
