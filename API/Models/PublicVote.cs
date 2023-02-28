namespace All4SA.Models
{
    public class PublicVote
    {
        public int PublicVoteID {get; set;}
        public string FirstName { get; set;}
        public string Surname { get; set;}
        public int JobRequestID { get; set;}
        public int Upvotes { get; set;}
        public int Downvotes { get; set;}
    }
}
