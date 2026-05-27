using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using TrabalhoLP.Properties.DAO;

namespace TrabalhoLP.Properties.Model
{
     public class Agendamento
    {
        public int Agendamento_ID { get; set; }

        public Pet Pet { get; set; }

        public DateTime? Data { get; set; }

        public string Horario { get; set; }

        public string Servicos { get; set; }

        public double Total { get; set; }

        public int Pet_ID { get; set; }

        public StatusAgendamento Status { get; set; }

        public enum StatusAgendamento
        {
            Pendente,
            Concluido,
            Cancelado
        }


        public string GerarResumo()
        {
            return
            $"     {Environment.NewLine}" +
            $"Pet: {Pet.Nome}{Environment.NewLine}" +
            $"Espécie: {Pet.Especie}{Environment.NewLine}" +
            $"Raça: {Pet.Raca}{Environment.NewLine}" +
            $"Data: {Data:dd/MM/yyyy}{Environment.NewLine}" +
            $"Horário: {Horario}{Environment.NewLine}" +
            $"Serviços: {Servicos}{Environment.NewLine}" +
            $"Total: R$ {Total:F2}{Environment.NewLine}" +
            $"Status: {Status}";
        }

        public List<Agendamento> GetAgendamentos()
        {
            SqlDataAdapter dataAdapter =new ConnectionSQL().MountQueryDataTable("SELECT * FROM Agendamentos");

            DataSet oDataSet =new DataSet();

            dataAdapter.Fill(oDataSet);

            DataTable oDataTable =oDataSet.Tables[0];

            List<Agendamento> lista =oDataTable.AsEnumerable().Select(row => new Agendamento
                {
                    Agendamento_ID = row.Field<int>("Id"),

                    Pet_ID =row.Field<int>("PetId"),

                    Data =row.Field<DateTime?>("Data"),

                    Horario = row.Field<string>("Horario"),

                    Servicos = row.Field<string>("Servicos"),

                    Total = Convert.ToDouble(row["Total"]),

                    Status =(StatusAgendamento)Enum.Parse(typeof(StatusAgendamento),row["Status"].ToString())
                })
                .ToList();

            return lista;
        }

        public string InsertAgendamento(Agendamento agendamento)
        {
            ConnectionSQL conn = new ConnectionSQL();

            SqlCommand cmd = conn.MountQuery(
                @"INSERT INTO Agendamentos
        (PetId, Data, Horario, Servicos, Total, Status)
        VALUES
        (@P1,@P2,@P3,@P4,@P5,@P6)");

            cmd.Parameters.AddWithValue("@P1", agendamento.Pet.Pet_ID);

            cmd.Parameters.AddWithValue("@P2",agendamento.Data);

            cmd.Parameters.AddWithValue("@P3", agendamento.Horario);

            cmd.Parameters.AddWithValue("@P4",agendamento.Servicos);

            cmd.Parameters.AddWithValue("@P5", agendamento.Total);

            cmd.Parameters.AddWithValue("@P6",agendamento.Status.ToString());

            conn.conn.Open();

            cmd.ExecuteNonQuery();

            conn.conn.Close();

            return "Agendamento cadastrado";
        }

        public string UpdateAgendamento( Agendamento agendamento)
        {
            ConnectionSQL conn = new ConnectionSQL();

            SqlCommand cmd = conn.MountQuery(
                @"UPDATE Agendamentos SET Status = @P1 WHERE Id = @P2");

            cmd.Parameters.AddWithValue("@P1", agendamento.Status.ToString());

            cmd.Parameters.AddWithValue( "@P2",agendamento.Agendamento_ID);

            conn.conn.Open();

            cmd.ExecuteNonQuery();

            conn.conn.Close();

            return "Status atualizado";
        }
    }
}
