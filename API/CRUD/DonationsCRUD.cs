using All4SA.Models;
using All4SA.Database;
using static All4SA.Database.DatabaseActions;
using Npgsql;

namespace All4SA.CRUD
{
    public class DonationsCRUD : DatabaseActionsBridge
    {
        public static new Donation GetByID(int ID)
        {
            return new Donation();
        }

        public static new List<Donation> GetAll()
        {
            return new List<Donation>();
        }

        public static DatabaseActionsResponses InsertEntry(Donation newEntry)
        {
            return DatabaseActionsResponses.Failed;
        }

        public static DatabaseActionsResponses UpdateEntryByID(Donation updateEntry)
        {
            try {
                using (NpgsqlCommand command = new NpgsqlCommand(
                    "UPDATE Donations SET Amount = Amount + CAST(@increase_amount as money) WHERE JobRequestID = @JobRequestID",
                    DatabaseConnection.GetConnection()))
                {

                    command.Parameters.AddWithValue("JobRequestID", updateEntry.JobRequestID);
                    command.Parameters.AddWithValue("increase_amount", updateEntry.Amount);

                    command.ExecuteNonQuery();
                }
            }
              catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return DatabaseActionsResponses.Failed;
            }
            return DatabaseActionsResponses.Success;
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
