﻿using All4SA.CRUD;
using All4SA.Models;
using Microsoft.AspNetCore.Mvc;

namespace All4SA.Controllers
{
    [ApiController]
    [Route("Addresses")]
    public class AddressesController : Controller
    {
        [HttpGet(Name = "GetAllAddresses")]
        public IActionResult GetAllAddresses()
        {
            return new ObjectResult(AddressesCRUD.GetAll());
        }
    }
}
