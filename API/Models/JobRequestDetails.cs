namespace All4SA.Models
{
    public class JobRequestDetails
    {
        public string firstName { get; set; }
        public int jobRequestID { get; set; }
        public string jobRequestDescription { get; set; }
        public string jobType { get; set; }
        public decimal estimatedCost { get; set; }
        public string imageReference { get; set; }
    }
}
