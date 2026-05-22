using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoLP.Properties.Model
{
    public class Gato
    {
        public string id { get; set; }

        public string url { get; set; }

        public int width { get; set; }

        public int height { get; set; }

        public List<RacaG> breeds { get; set; }


        private string URLAPI { get; } = "https://api.thecatapi.com/v1/images/search";


        public async Task<Gato> getGato()
        {
            Gato gato = new Gato();

            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(URLAPI);

            string responseBody = await response.Content.ReadAsStringAsync();

            List<Gato> lista =
                JsonConvert.DeserializeObject<List<Gato>>(responseBody);

            gato = lista[0];

            return gato;
        }
    }


    public class RacaG
    {
        public string name { get; set; }

        public string temperament { get; set; }

        public string life_span { get; set; }

        public string bred_for { get; set; }
    }

    public class CatApi
    {
        private string URLAPI = "https://api.thecatapi.com/v1/breeds";

        private string APIKEY = "live_AKMfFk8qpYf16buuqcdHfPZI96eLn6qPJ6MinfHuv5OKecU71M3l02FhVxbgSx2v";


        public async Task<List<string>> GetRacas()
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("x-api-key", APIKEY);

            string response =
                await client.GetStringAsync(URLAPI);

            List<RacaCat> lista =
                JsonConvert.DeserializeObject<List<RacaCat>>(response);

            return lista.Select(r => r.name).ToList();
        }
    }


    public class RacaCat
    {
        public string name { get; set; }
    }
}