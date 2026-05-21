using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoLP.Properties.Model
{
    internal class Agendamento
    {
        public DateTime? Data { get; set; }

        public string Horario { get; set; }

        public string Servicos { get; set; }

        public double Total { get; set; }


        public string GerarResumo()
        {
            return
                $"     {Environment.NewLine}" +
                $"Data: {Data:dd/MM/yyyy}{Environment.NewLine}" +
                $"Horário: {Horario}{Environment.NewLine}" +
                $"Serviços: {Servicos}{Environment.NewLine}" +
                $"Total: R$ {Total:F2}";

        }
    }
}