using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoLP.Properties.Model
{
    public class Cachorro
    {
        public string id { get; set; }

        public string url { get; set; }

        public int width { get; set; }

        public int height { get; set; }

        public List<RacaCachorro> breeds { get; set; }


        private const string APIKEY =
            "live_98a9p26vts2XQaiFteKAEaoTlSlv0izXMetJZT09rNDmPRVBRLmntEAIbHAwoZcD";

        private string URLImagem =
            "https://api.thedogapi.com/v1/images/search";

        private string URLRacas =
            "https://api.thedogapi.com/v1/breeds";


        private HttpClient CriarClient()
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add(
                "x-api-key",
                APIKEY
            );

            return client;
        }


        // Buscar imagem aleatória
        public async Task<Cachorro> GetCachorro()
        {
            HttpClient client = CriarClient();

            HttpResponseMessage response =
                await client.GetAsync(URLImagem);

            string responseBody =
                await response.Content.ReadAsStringAsync();

            List<Cachorro> lista =
                JsonConvert.DeserializeObject<List<Cachorro>>(responseBody);

            return lista[0];
        }


        // Buscar lista de raças
        public async Task<List<string>> GetRacas()
        {
            HttpClient client = CriarClient();

            string response =
                await client.GetStringAsync(URLRacas);

            List<RacaCachorro> lista =
                JsonConvert.DeserializeObject<List<RacaCachorro>>(response);

            return lista.Select(r => r.name).ToList();
        }
    }


    public class RacaCachorro
    {
        public string name { get; set; }

        public string temperament { get; set; }

        public string life_span { get; set; }

        public string bred_for { get; set; }
    }
}


