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
            return new ObjectResult("");
        }

        [HttpGet("GetAddressByID/{addressID}", Name = "GetAddressByID")]
        public IActionResult GetAddressByID(int addressID)
        {
            return new ObjectResult("");
        }

        [HttpPost("AddAddress", Name = "AddAddress")]
        public IActionResult AddAddress(int userID, string province, string city, string streetName, int postalCode)
        {
            return new ObjectResult("");
        }

        [HttpPut("UpdateAddress/{addressID}", Name = "UpdateAddress")]
        public IActionResult UpdateAddress(int addressID, string province, string city, string streetName, int postalCode)
        {
            return new ObjectResult("");
        }

        [HttpPut("SoftDeleteAddress/{addressID}", Name = "SoftDeleteAddress")]
        public IActionResult SoftDeleteAddress(int addressID)
        {
            return new ObjectResult("");
        }

        [HttpDelete("DeleteAddress/{addressID}", Name = "DeleteAddress")]
        public IActionResult DeleteAddress(int addressID)
        {
            return new ObjectResult("");
        }
    }
}
