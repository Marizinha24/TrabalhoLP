using System;
using System.Data.SqlClient;

namespace TrabalhoLP.Properties.DAO
{
    public class ConnectionSQL
    {
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=PetCare;Integrated Security=True;";

        public SqlCommand MountQuery(string sql)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);

            try
            {
                connection.Open();
                return command;
            }
            catch (Exception ex)
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
                throw new Exception("Erro ao conectar ao banco: " + ex.Message);
            }
        }
    }
}