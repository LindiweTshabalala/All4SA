﻿using All4SA.CRUD;
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
            return new ObjectResult((UsersCRUD.GetAll()));
        }

        [HttpGet("GetUserByID/{userID}", Name = "GetUserByID")]
        public IActionResult GetUserByID(int userID)
        {
            return new ObjectResult(UsersCRUD.GetByID(userID));
        }

        [HttpGet("GetUserByToken/{token}", Name = "GetUserByToken")]
        public IActionResult GetUserByToken(string token)
        {
            return new ObjectResult(UsersCRUD.GetByToken(token));
        }

        [HttpGet("GetUserID/{firstname}/{surname}", Name = "GetUserID")]
        public IActionResult GetUserID(string firstname, string surname)
        {
            User user = new User
            {
                firstName= firstname,
                Surname= surname,
            };
            return new ObjectResult(UsersCRUD.GetUserID(user));
        }

        [HttpGet("AddUser/{name}/{surname}/{token}", Name = "AddUser")]
        public IActionResult AddUser( string name, string surname, string token )
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
    }
}
