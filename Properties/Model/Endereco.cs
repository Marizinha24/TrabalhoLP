using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoLP.Properties.Model
{
    public class Endereco
    {
        public string CEP { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Localidade { get; set; }

        public string Cidade { get; set; }

        public string UF { get; set; }

        private string URLAPI { get; } = "https://viacep.com.br/ws/";

        public async Task<Endereco> getEndereco(string CEP)
        {
            Endereco endereco = new Endereco();
            if (CEP != string.Empty)
            {
                HttpClient client = new HttpClient();
                //client.BaseAddress = new Uri(URLAPI);
                HttpResponseMessage response = await client.GetAsync(URLAPI + CEP + "/json");
                string responseBody = await response.Content.ReadAsStringAsync();
                endereco = JsonConvert.DeserializeObject<Endereco>(responseBody);
                endereco.Cidade = endereco.Localidade;
            }

            return endereco;
        }

    }
}