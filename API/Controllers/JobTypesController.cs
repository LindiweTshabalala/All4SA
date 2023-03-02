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
            try
            {
                return new ObjectResult(JobTypesCRUD.GetAll());
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
