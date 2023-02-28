using All4SA.CRUD;
using All4SA.Models;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult AddDonation(Donation donation)
        {
            return new ObjectResult("");
        }



        [HttpPut("UpdateDonation/{jobRequestID}/{amount}", Name = "UpdateDonation")]
        public IActionResult UpdateDonation(int jobRequestID, decimal amount)
        {
            Donation donation = new Donation();
            donation.Amount = amount;
            donation.JobRequestID = jobRequestID;
            return new ObjectResult(DonationsCRUD.UpdateEntryByID(donation));
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
