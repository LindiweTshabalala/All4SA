namespace All4SA.Models
{
    public class User
    {
        public int userID { get; set; }
        public string firstName { get; set; }
        public string Surname { get; set; }
        public string idNumber { get; set; }
        public string token { get; set; }
        public bool isDeleted { get; set; }
    }
}
