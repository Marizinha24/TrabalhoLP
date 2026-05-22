using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoLP.Properties.Model
{
    public class Pet
    {
        public string Nome { get; set; }

        public string Especie { get; set; }

        public string Raca { get; set; }

        public string ImagemURL { get; set; }

        public List<Agendamento> Agendamentos { get; set; }
            = new List<Agendamento>();
    }
}