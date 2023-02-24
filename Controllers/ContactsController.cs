using Microsoft.AspNetCore.Mvc;

namespace All4SA.Controllers
{
    [ApiController]
    [Route("Contacts")]
    public class ContactsController : Controller
    {
        [HttpGet(Name = "GetAllContacts")]
        public IActionResult GetAllContacts()
        {
            return new ObjectResult("");
        }

        [HttpGet("GetContactByID/{contactID}", Name = "GetContactByID")]
        public IActionResult GetContactByID(int contactID)
        {
            return new ObjectResult("");
        }

        [HttpPost("AddContact", Name = "AddContact")]
        public IActionResult AddContact(string email, string cellphone, int userID)
        {
            return new ObjectResult("");
        }

        [HttpPut("UpdateContact/{contactID}", Name = "UpdateContact")]
        public IActionResult UpdateContact(int contactID, string email, string cellphone, int userID)
        {
            return new ObjectResult("");
        }

        [HttpPut("SoftDeleteContact/{contactID}", Name = "SoftDeleteContact")]
        public IActionResult SoftDeleteContact(int contactID)
        {
            return new ObjectResult("");
        }

        [HttpDelete("DeleteContact/{contactID}", Name = "DeleteContact")]
        public IActionResult DeleteContact(int contactID)
        {
            return new ObjectResult("");
        }
    }
}
