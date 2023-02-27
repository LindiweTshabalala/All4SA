﻿using All4SA.Database;
using All4SA.Models;
using Npgsql;
using System.Net;
using static All4SA.Database.DatabaseActions;

namespace All4SA.CRUD
{
    public class JobRequestsCRUD : DatabaseActionsBridge
    { 
        public static new JobRequest GetByID(int ID)
        {
            return new JobRequest();
        }


        public static new List<JobRequest> GetJobRequests()
        {
            List<JobRequest> requests = new List<JobRequest>();

            string query = "SELECT * FROM JobRequests";

            using NpgsqlCommand command = new NpgsqlCommand(query, DatabaseConnection.GetConnection());
            using NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                requests.Add(new JobRequest
                {
                    JobRequestID = reader.GetInt32(0),
                    JobRequestDescription = reader.GetString(1),
                    UserID = reader.GetInt32(2),
                    ImageReferenceID = reader.GetInt32(3),
                    JobTypeID = reader.GetInt32(4),
                    EstimatedCost = reader.GetDecimal(5),
                    Status = reader.GetBoolean(6)

            });
            }
            requests.Add(new JobRequest());
            return requests;
        }



        public static DatabaseActionsResponses InsertEntry(JobRequest newEntry)
        {
            return DatabaseActionsResponses.Failed;
        }

        public static DatabaseActionsResponses UpdateEntryByID(JobRequest updateEntry)
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
