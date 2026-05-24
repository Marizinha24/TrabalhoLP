using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoLP.Properties.Model
{
    public class Cachorro
    {
        public class DogResponse
        {
            public string message { get; set; }

            public string status { get; set; }
        }

        public class ListaRacas
        {
            public Dictionary<string, List<string>> message { get; set; }

            public string status { get; set; }
        }


        // LISTAR RAÇAS
        public async Task<List<string>> GetRacas()
        {
            HttpClient client = new HttpClient();

            string response = await client.GetStringAsync("https://dog.ceo/api/breeds/list/all");

            ListaRacas lista = JsonConvert.DeserializeObject<ListaRacas>(response);

            return lista.message.Keys.ToList();
        }



        // IMAGEM POR RAÇA
        public async Task<string> GetImagemPorRaca(string raca)
        {
            HttpClient client = new HttpClient();

            raca = raca.ToLower();

            string url = $"https://dog.ceo/api/breed/{raca}/images/random";

            string response = await client.GetStringAsync(url);

            DogResponse dog = JsonConvert.DeserializeObject<DogResponse>(response);

            return dog.message;
        }
    }
}