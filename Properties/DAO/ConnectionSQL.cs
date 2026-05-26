using System;
using System.Data.SqlClient;

namespace TrabalhoLP.Properties.DAO
{
    public class ConnectionSQL
    {
        private static string connectionSTRING = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=PetCare;Integrated Security=True;";

        public SqlConnection conn =new SqlConnection(connectionSTRING);

        public SqlCommand MountQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conn);

            return cmd;
        }

        public SqlDataAdapter MountQueryDataTable(string query)
        {
            SqlDataAdapter dataAdapter =
                new SqlDataAdapter(query, conn);

            return dataAdapter;
        }
    }
}