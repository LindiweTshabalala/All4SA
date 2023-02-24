using Microsoft.AspNetCore.Mvc;
using System.Data.SqlTypes;

namespace All4SA.Controllers
{
    [ApiController]
    [Route("Donations")]
    public class DonationsController : Controller
    {
        [HttpGet(Name = "GetAllDonations")]
        public IActionResult GetAllDonations()
        {
            return new ObjectResult("");
        }

        [HttpGet("GetDonationByID/{donationID}", Name = "GetDonationByID")]
        public IActionResult GetDonationByID(int donationID)
        {
            return new ObjectResult("");
        }

        [HttpPost("AddDonation", Name = "AddDonation")]
        public IActionResult AddDonation(int userID, int amount, int jobRequestID)
        {
            return new ObjectResult("");
        }

        [HttpPut("UpdateDonation/{donationID}", Name = "UpdateDonation")]
        public IActionResult UpdateDonation(int donationID, int userID, int amount, int jobRequestID)
        {
            return new ObjectResult("");
        }

        [HttpPut("SoftDeleteDonation/{donationID}", Name = "SoftDeleteDonation")]
        public IActionResult SoftDeleteDonation(int donationID)
        {
            return new ObjectResult("");
        }

        [HttpDelete("DeleteDonation/{donationID}", Name = "DeleteDonation")]
        public IActionResult DeleteDonation(int donationID)
        {
            return new ObjectResult("");
        }
    }
}
