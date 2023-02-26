using All4SA.Models;
using Microsoft.AspNetCore.Mvc;

namespace All4SA.Controllers
{
    [ApiController]
    [Route("Statuses")]
    public class StatusesController : Controller
    {
        [HttpGet(Name = "GetAllStatuses")]
        public IActionResult GetAllStatuses()
        {
            return new ObjectResult("");
        }

        [HttpGet("GetStatusByID/{statusID}", Name = "GetStatusByID")]
        public IActionResult GetStatusByID(int statusID)
        {
            return new ObjectResult("");
        }

        [HttpPost("AddStatus", Name = "AddStatus")]
        public IActionResult AddStatus(Status  status)
        {
            return new ObjectResult("");
        }

        [HttpPut("UpdateStatus/{statusID}", Name = "UpdateStatus")]
        public IActionResult UpdateStatus(Status status)
        {
            return new ObjectResult("");
        }

        [HttpPut("SoftDeleteStatus/{statusID}", Name = "SoftDeleteStatus")]
        public IActionResult SoftDeleteStatus(int statusID)
        {
            return new ObjectResult("");
        }

        [HttpDelete("DeleteStatus/{statusID}", Name = "DeleteStatus")]
        public IActionResult DeleteStatus(int statusID)
        {
            return new ObjectResult("");
        }
    }
}
