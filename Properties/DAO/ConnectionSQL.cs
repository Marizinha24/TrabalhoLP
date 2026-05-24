using System;
using System.Data.SqlClient;

namespace TrabalhoLP.Properties.DAO
{
    public class ConnectionSQL
    {
        private static string connectionSTRING = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=PetCare;Integrated Security=True;";


        public SqlConnection conn = new SqlConnection(connectionSTRING);

        public SqlCommand MountQuery(string query)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            conn.Close();
            return cmd;
        }

        public SqlDataAdapter MountQueryDataTable(string query)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd.CommandText, conn);
            conn.Close();
            return dataAdapter;
        }
    }
}