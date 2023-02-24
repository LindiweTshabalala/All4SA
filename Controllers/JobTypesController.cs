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
    }
}
