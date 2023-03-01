using System.ComponentModel.DataAnnotations;

namespace All4SA.Models
{
    public class UserDetailsModel
    {
        public string firstName { get; set; }
        public string surname { get; set; }       
        public string idNumber { get; set; }       
        public string token { get; set; }       
        public string email { get; set; }        
        public string cellphone { get; set; }       
        public string province { get; set; }       
        public string city { get; set; }
        public string streetName { get; set; }       
        public int postalCode { get; set; }
    }

}
