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
    }
}
