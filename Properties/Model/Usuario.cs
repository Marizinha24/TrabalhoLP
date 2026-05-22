using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoLP.Properties.Model
{
    public class Usuario
    {
        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public Endereco Endereco { get; set; }

        public List<Pet> Pets { get; set; }
            = new List<Pet>();
    }
}
