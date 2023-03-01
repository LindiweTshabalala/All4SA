using All4SA.CRUD;
using All4SA.Models;
using Microsoft.AspNetCore.Mvc;

namespace All4SA.Controllers
{ 

    [ApiController]
    [Route("api/users")]
    public class UserDetailsController : ControllerBase
    {
        [HttpPost]
        public IActionResult AddUser([FromBody] UserDetailsModel request)
        {
            try
            {
                UserDetailsCRUD.AddUser(request);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }

}
