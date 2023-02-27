using All4SA.Database;

namespace All4SA.Models
{
    public class Address : DatabaseActionsBridge
    {
        public int AddressID { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string StreetName { get; set; }
        public int PostalCode { get; set; }
        public int UserID { get; set; }
    }
}
