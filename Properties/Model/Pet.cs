using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using TrabalhoLP.Properties.DAO;

namespace TrabalhoLP.Properties.Model
{
    public class Pet
    {
        public int Pet_ID { get; set; }
        public string Nome { get; set; }

        public string Especie { get; set; }

        public string Raca { get; set; }

        public string ImagemURL { get; set; }

        public int Usuario_ID { get; set; }


        public Usuario Usuario { get; set; }

        public List<Agendamento> Agendamentos { get; set; }
            = new List<Agendamento>();

        public List<Pet> GetPets()
        {
            SqlDataAdapter dataAdapter = new ConnectionSQL().MountQueryDataTable(
            @"SELECT
            P.Id,
            P.Nome,
            P.Especie,
            P.Raca,
            P.ImagemURL,
            P.UsuarioId,

            U.Id AS Usuario_ID,
            U.Nome AS NomeUsuario

          FROM Pets P

          INNER JOIN Usuarios U
          ON P.UsuarioId = U.Id");


            DataSet oDataSet = new DataSet();

            dataAdapter.Fill(oDataSet);

            DataTable oDataTable = oDataSet.Tables[0];


            List<Pet> lista = oDataTable.AsEnumerable()
                .Select(row => new Pet
                {
                    Pet_ID = row.Field<int>("Id"),

                    Nome = row.Field<string>("Nome"),

                    Especie = row.Field<string>("Especie"),

                    Raca = row.Field<string>("Raca"),

                    ImagemURL = row.Field<string>("ImagemURL"),

                    Usuario_ID = row.Field<int>("UsuarioId"),

                    Usuario = new Usuario
                    {
                        Usuario_ID =
                    row.Field<int>("Usuario_ID"),

                        Nome =
                    row.Field<string>("NomeUsuario")
                    }

                }).ToList();

            return lista;
        }

        public string InsertPet(Pet pet)
        {
            ConnectionSQL conn = new ConnectionSQL();

            SqlCommand cmd = conn.MountQuery(
                @"INSERT INTO Pets
        (Nome,Especie,Raca,ImagemURL,UsuarioId)
        VALUES
        (@P1,@P2,@P3,@P4,@P5)");

            cmd.Parameters.AddWithValue("@P1", pet.Nome);
            cmd.Parameters.AddWithValue("@P2", pet.Especie);

            cmd.Parameters.AddWithValue("@P3", pet.Raca);

            cmd.Parameters.AddWithValue("@P4",(object)pet.ImagemURL ?? DBNull.Value);

            cmd.Parameters.AddWithValue("@P5", pet.Usuario_ID);

            conn.conn.Open();

            cmd.ExecuteNonQuery();

            conn.conn.Close();

            return "Pet cadastrado";
        }
    }
}