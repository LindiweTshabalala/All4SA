namespace All4SA.Models
{
    public class Donation
    {
        public int DonationID { get; set; }
        public decimal Amount { get; set; }
        public int UserID { get; set; }
        public int JobRequestID { get; set; }
    }
}
