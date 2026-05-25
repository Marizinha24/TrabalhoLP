using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using TrabalhoLP.Properties.DAO;

namespace TrabalhoLP.Properties.Model
{
    public class Usuario
    {
        public int Usuario_ID { get; set; }
        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public string? Endereco { get; set; }

        public List<Pet> Pets { get; set; } = new List<Pet>();

        // LISTAR USUÁRIOS
        public List<Usuario> GetUsuarios()
        {
            SqlDataAdapter dataAdapter = new ConnectionSQL().MountQueryDataTable("SELECT * FROM Usuarios");

            DataSet oDataSet = new DataSet();

            dataAdapter.Fill(oDataSet);

            DataTable oDataTable = oDataSet.Tables[0];


            List<Usuario> lista =
                oDataTable.AsEnumerable()
                .Select(row => new Usuario
                {
                    Usuario_ID = row.Field<int>("Id"),
                    Nome = row.Field<string>("Nome"),
                    CPF = row.Field<string>("CPF"),
                    Telefone = row.Field<string>("Telefone"),
                    Email = row.Field<string>("Email"),
                    Endereco = row.Field<string>("Endereco")
                }).ToList();
            return lista;
        }


        // INSERT
        public int InsertUsuario(Usuario usuario)
        {
            ConnectionSQL conn = new ConnectionSQL();

            SqlCommand cmd = conn.MountQuery(
                @"INSERT INTO Usuarios(Nome,CPF,Telefone,Email,Endereco)

                 OUTPUT INSERTED.Id VALUES(@P1,@P2,@P3,@P4,@P5)");

            cmd.Parameters.AddWithValue("@P1", usuario.Nome);
            cmd.Parameters.AddWithValue("@P2", usuario.CPF);
            cmd.Parameters.AddWithValue("@P3", usuario.Telefone);
            cmd.Parameters.AddWithValue("@P4", usuario.Email);
            cmd.Parameters.AddWithValue("@P5", usuario.Endereco);

            conn.conn.Open();

            int idGerado = (int)cmd.ExecuteScalar();

            conn.conn.Close();

            return idGerado;
        }


        public string DeleteUsuario(int ID)
        {
            ConnectionSQL conn = new ConnectionSQL();

            conn.conn.Open();


            // DELETA AGENDAMENTOS
            SqlCommand cmdAg = conn.MountQuery(
            @"DELETE FROM Agendamentos WHERE PetId IN
            (SELECT Id FROM Pets WHERE UsuarioId = @P1)");

            cmdAg.Parameters.AddWithValue("@P1", ID);

            cmdAg.ExecuteNonQuery();



            // DELETA PETS
            SqlCommand cmdPets = conn.MountQuery(
            @"DELETE FROM Pets WHERE UsuarioId = @P1");

            cmdPets.Parameters.AddWithValue("@P1", ID);

            cmdPets.ExecuteNonQuery();



            // DELETA USUÁRIO
            SqlCommand cmdUsuario = conn.MountQuery(
            @"DELETE FROM Usuarios WHERE Id = @P1");

            cmdUsuario.Parameters.AddWithValue("@P1", ID);

            cmdUsuario.ExecuteNonQuery();


            conn.conn.Close();

            return "Registro deletado do sistema";
        }
    }
}


