using All4SA.Database;
using All4SA.Models;
using Npgsql;
using static All4SA.Database.DatabaseActions;

namespace All4SA.CRUD
{
    public class UsersCRUD : DatabaseActionsBridge
    {
        public static new User GetByID(int userID)
        {
            User user = new();
            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM Users WHERE UserID = @UserID", DatabaseConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("userID", userID);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User
                            {
                                userID = reader.GetInt32(0),
                                firstName = reader.GetString(1),
                                Surname = reader.GetString(2),
                                idNumber = reader.GetString(3),
                                token = reader.GetString(4),
                                isDeleted = reader.GetBoolean(5),
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return user;
        }

        public static int GetUserID(User user)
        {
            int result = 0;
            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT userid FROM Users WHERE firstname = @firstname and surname = @surname", DatabaseConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("firstname", user.firstName);
                    cmd.Parameters.AddWithValue("surname", user.Surname);

                    result = (int)cmd.ExecuteScalar();
                    return result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        public static new User GetByToken(string token)
        {
            User user = new();
            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM Users WHERE token = @token", DatabaseConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("token", token);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User
                            {
                                userID = reader.GetInt32(0),
                                firstName = reader.GetString(1),
                                Surname = reader.GetString(2),
                                idNumber = reader.GetString(3),
                                token = reader.GetString(4),
                                isDeleted = reader.GetBoolean(5),
                            };

                            return user;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public static new List<User> GetAll()
        {
            List<User> userList = new List<User>();
            User user = new();
            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM Users", DatabaseConnection.GetConnection()))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user = new User
                            {
                                userID = reader.GetInt32(0),
                                firstName = reader.GetString(1),
                                Surname = reader.GetString(2),
                                idNumber = reader.GetString(3),
                                token = reader.GetString(4),
                                isDeleted = reader.GetBoolean(5),
                            };
                            userList.Add(user);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return userList;
    }

        public static DatabaseActionsResponses InsertEntry(User newEntry)
        {
            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO Users (firstName, Surname, idNumber, token) VALUES (@firstName, @surname, @idNumber, @token)", DatabaseConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("firstName", newEntry.firstName);
                    cmd.Parameters.AddWithValue("surname", newEntry.Surname);
                    cmd.Parameters.AddWithValue("idNumber", newEntry.idNumber);
                    cmd.Parameters.AddWithValue("token", newEntry.token);
                    //cmd.Parameters.AddWithValue("isDeleted", newEntry.isDeleted ? 0 : 1);
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return DatabaseActionsResponses.Failed;
            }
            return DatabaseActionsResponses.Success;
        }



        public static DatabaseActionsResponses UpdateEntryByID(User updateEntry)
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
