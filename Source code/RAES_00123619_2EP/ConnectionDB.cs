using System;
using System.Data;
using Npgsql;

namespace RAES_00123619_2EP
{
    public static class ConnectionDB
    {
        private static String host = "localhost",
            database = "postgres",
            userID = "postgres",
            password = "uca";

        private static String sConnection =
            $"Host={host};Port = 5432; User Id = {userID}; Password={password};Database={database}";

        public static DataTable ExecuteQuery(string query)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            DataSet ds = new DataSet();
            connection.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            da.Fill(ds);
            connection.Close();
            return ds.Tables[0];
        }

        public static void ExecuteNonQuery(string action)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(action, connection);
            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}