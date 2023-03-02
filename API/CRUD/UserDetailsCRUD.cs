using All4SA.Database;
using All4SA.Models;
using Npgsql;
using System.Data;
using static All4SA.Database.DatabaseActions;

namespace All4SA.CRUD
{
    public class UserDetailsCRUD
    {
        public static void AddUser(UserDetailsModel request)
        {
            using (NpgsqlTransaction tran = DatabaseConnection.GetConnection().BeginTransaction())
            {
                try
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand("sp_add_user_details", DatabaseConnection.GetConnection()))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("first_name", request.firstName);
                        cmd.Parameters.AddWithValue("surname", request.surname);
                        cmd.Parameters.AddWithValue("id_number", request.idNumber);
                        cmd.Parameters.AddWithValue("token_", request.token);
                        cmd.Parameters.AddWithValue("email", request.email);
                        cmd.Parameters.AddWithValue("cell_phone", request.cellphone);
                        cmd.Parameters.AddWithValue("province", request.province);
                        cmd.Parameters.AddWithValue("city", request.city);
                        cmd.Parameters.AddWithValue("street_name", request.streetName);
                        cmd.Parameters.AddWithValue("postal_code", request.postalCode);

                        cmd.ExecuteNonQuery();
                    }

                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
        }

    }
}
