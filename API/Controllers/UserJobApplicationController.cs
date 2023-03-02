using All4SA.CRUD;
using All4SA.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using static All4SA.Database.DatabaseActions;

namespace All4SA.Controllers
{
    [ApiController]
    [Route("UserJobApplication")]
    public class UserJobApplicationController : Controller
    {
        [HttpGet(Name = "GetAllUserJobApplications")]
        public IActionResult GetAllUserJobApplications()
        {
            return new ObjectResult(UserJobApplicationsCRUD.GetAll());
        }

        [HttpPost("AddUserJobApplication/{jobRequestID}/{userID}", Name = "AddUserJobApplication")]
        public IActionResult AddUserJobApplication(int jobRequestID, int userID)
        {
            try
            {
                PublicVote publicVote = new PublicVote
                {
                    JobRequestID= jobRequestID,
                    UserID=userID,
                    Upvotes = 0,
                    Downvotes= 0,
                };
                DatabaseActionsResponses response = UserJobApplicationsCRUD.InsertEntry(publicVote);
                Console.WriteLine("Saved User: " + response);
                return new ObjectResult(UserJobApplicationsCRUD.InsertEntry(publicVote));
            } catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("UpvoteByUserID/{jobRequestID}/{userID}", Name = "UpvoteByUserID")]
        public IActionResult UpvoteByUserID(int jobRequestID, int userID)
        {
            Console.WriteLine("jobRequestID: "+ jobRequestID);
            Console.WriteLine("userID: " + userID);

            PublicVote publicVote = new PublicVote
            {
                UserID=userID,
                JobRequestID= jobRequestID,
            };
            return new ObjectResult(UserJobApplicationsCRUD.UpdateEntryByID_upvote(publicVote));
        }

        [HttpPut("DownvoteByUserID/{jobRequestID}/{userID}", Name = "DownvoteByUserID")]
        public IActionResult DownvoteByUserID(int jobRequestID, int userID)
        {
            Console.WriteLine("jobRequestID: " + jobRequestID);
            Console.WriteLine("userID: " + userID);

            PublicVote publicVote = new PublicVote
            {
                UserID = userID,
                JobRequestID = jobRequestID,
            };
            return new ObjectResult(UserJobApplicationsCRUD.UpdateEntryByID_downvote(publicVote));
        }
    }
}
