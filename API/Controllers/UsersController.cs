using All4SA.CRUD;
using All4SA.Models;
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
            try
            {
                return new ObjectResult((UsersCRUD.GetAll()));
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        [HttpGet("GetUserByID/{userID}", Name = "GetUserByID")]
        public IActionResult GetUserByID(int userID)
        {
            try
            {
                return new ObjectResult(UsersCRUD.GetByID(userID));
            }
            catch(Exception ex) 
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("GetUserByToken/{token}", Name = "GetUserByToken")]
        public IActionResult GetUserByToken(string token)
        {
            try
            {
                return new ObjectResult(UsersCRUD.GetByToken(token));
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("GetUserID/{firstname}/{surname}", Name = "GetUserID")]
        public IActionResult GetUserID(string firstname, string surname)
        {
            try
            {
                User user = new User
                {
                    firstName = firstname,
                    Surname = surname,
                };
                return new ObjectResult(UsersCRUD.GetUserID(user));
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("AddUser/{name}/{surname}/{token}", Name = "AddUser")]
        public IActionResult AddUser( string name, string surname, string token )
        {
            try
            {
                User user = new User()
                {
                    firstName = name,
                    Surname = surname,
                    idNumber = "0000000000000",
                    token = token,
                    isDeleted = false
                };

                User? checkUser = UsersCRUD.GetByToken(token);


                if (checkUser == null)
                {
                    UsersCRUD.InsertEntry(user);
                    return new ObjectResult(user);
                }

                return new ObjectResult(checkUser);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
