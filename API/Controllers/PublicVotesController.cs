using All4SA.CRUD;
using All4SA.Models;
using Microsoft.AspNetCore.Http.HttpResults;
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
            return new ObjectResult(PublicVotesCRUD.GetAll());
        }

        [HttpGet("GetPublicVoteByID/{publicVoteID}", Name = "GetPublicVoteByID")]
        public IActionResult GetPublicVoteByID(int publicVoteID)
        {
            return new ObjectResult("");
        }

        [HttpPost("AddPublicVote", Name = "AddPublicVote")]
        public IActionResult AddPublicVote(PublicVote publicVote)
        {
            try
            {
                PublicVotesCRUD.InsertEntry(publicVote);
                return Ok();
            } catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("UpdatePublicVote/{publicVoteID}", Name = "UpdatePublicVote")]
        public IActionResult UpdatePublicVote(PublicVote publicVote)
        {
            return new ObjectResult("");
        }

        [HttpPut("UpVoteRequest/{publicVoteID}", Name = "UpVoteRequest")]
        public IActionResult UpVoteRequest(int publicVoteID)
        {
            return new ObjectResult("");
        }

        [HttpPut("DownVoteRequest/{publicVoteID}", Name = "DownVoteRequest")]
        public IActionResult DownVoteRequest(int publicVoteID)
        {
            return new ObjectResult("");
        }

        [HttpPut("SoftDeletePublicVote/{publicVoteID}", Name = "SoftDeletePublicVote")]
        public IActionResult SoftDeletePublicVote(int publicVoteID)
        {
            return new ObjectResult("");
        }

        [HttpDelete("DeletePublicVote/{publicVoteID}", Name = "DeletePublicVote")]
        public IActionResult DeletePublicVote(int publicVoteID)
        {
            return new ObjectResult("");
        }
    }
}
