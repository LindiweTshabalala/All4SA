using Microsoft.AspNetCore.Mvc;

namespace All4SA.Controllers
{
    [ApiController]
    [Route("Users")]
    public class UsersController : Controller
    {
        [HttpGet(Name = "GetAllUsers")]
        public IActionResult GetAllUsers()
        {
            return new ObjectResult("");
        }

        [HttpGet("GetUserByID/{userID}", Name = "GetUserByID")]
        public IActionResult GetUserByID(int userID)
        {
            return new ObjectResult("");
        }

        [HttpPost("AddUser", Name = "AddUser")]
        public IActionResult AddUser(string firstName, string surname, string identityCode, string loginToken)
        {
            return new ObjectResult("");
        }

        [HttpPut("UpdateUser/{userID}", Name = "UpdateUser")]
        public IActionResult UpdateUser(int userID, string firstName, string surname, string identityCode, string loginToken)
        {
            return new ObjectResult("");
        }

        [HttpPut("SoftDeleteUser/{userID}", Name = "SoftDeleteUser")]
        public IActionResult SoftDeleteUser(int userID)
        {
            return new ObjectResult("");
        }

        [HttpDelete("DeleteUser/{userID}", Name = "DeleteUser")]
        public IActionResult DeleteUser(int userID)
        {
            return new ObjectResult("");
        }
    }
}
