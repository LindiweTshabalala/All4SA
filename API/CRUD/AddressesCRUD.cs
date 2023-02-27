using All4SA.Models;
using All4SA.Database;
using static All4SA.Database.DatabaseActions;
using Npgsql;

namespace All4SA.CRUD
{
    public class AddressesCRUD : DatabaseActionsBridge
    {
        public static new Address GetByID(int ID)
        {
            return new Address();
        }

        public static new List<Address> GetAll()
        {
            List<Address> addresses = new List<Address>();

            string query = "SELECT * FROM Addresses ";
            using NpgsqlCommand command = new NpgsqlCommand(query, DatabaseConnection.GetConnection());
            using NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                addresses.Add(new Address
                {
                    AddressID = reader.GetInt32(0),
                    Province = reader.GetString(1),
                    City = reader.GetString(2),
                    StreetName = reader.GetString(3),
                    PostalCode = reader.GetInt32(4),
                    UserID = reader.GetInt32(5)

                });
            }
            addresses.Add(new Address());
            return addresses;
        }

        public static DatabaseActionsResponses InsertEntry(Address newEntry)
        {
            return DatabaseActionsResponses.Failed;
        }

        public static DatabaseActionsResponses UpdateEntryByID(Address updateEntry)
        {
            return DatabaseActionsResponses.Failed;
        }

        public static new DatabaseActionsResponses DeleteEntryByID(int ID)
        {
            return DatabaseActionsResponses.Failed;
        }
        public static new DatabaseActionsResponses DeleteAll()
        {
            return DatabaseActionsResponses.Failed;
        }
        public static new DatabaseActionsResponses SoftDeleteEntryByID(int ID)
        {
            return DatabaseActionsResponses.Failed;
        }
    }
}
