namespace All4SA.Models
{
    public class JobRequestDetailsDTO
    {
        public int JobRequestID { get; set; }
        public string JobRequestDescription { get; set; }
        public int UserID { get; set; }
        public string ImageReferenceID { get; set; }
        public int JobTypeID { get; set; }
        public decimal EstimatedCost { get; set; }
        public bool Status { get; set; }
    }
}
