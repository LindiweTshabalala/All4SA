using All4SA.CRUD;
using All4SA.Models;
using Microsoft.AspNetCore.Mvc;

namespace All4SA.Controllers
{
    [ApiController]
    [Route("Donations")]
    public class DonationsController : Controller
    {
        [HttpPut("UpdateDonation/{jobRequestID}/{amount}", Name = "UpdateDonation")]
        public IActionResult UpdateDonation(int jobRequestID, decimal amount)
        {
            Donation donation = new Donation();
            donation.Amount = amount;
            donation.JobRequestID = jobRequestID;
            return new ObjectResult(DonationsCRUD.UpdateEntryByID(donation));
        }
    }
}
