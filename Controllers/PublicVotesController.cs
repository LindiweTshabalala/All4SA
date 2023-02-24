using Microsoft.AspNetCore.Mvc;

namespace All4SA.Controllers
{
    [ApiController]
    [Route("PublicVotes")]
    public class PublicVotesController : Controller
    {
        [HttpGet(Name = "GetAllPublicVotes")]
        public IActionResult GetAllPublicVotes()
        {
            return new ObjectResult("");
        }
    }
}
