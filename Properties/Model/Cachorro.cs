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

        public List<RacaC> breeds { get; set; }


        private string URLAPI { get; } = "https://api.thedogapi.com/v1/images/search";


        public async Task<Cachorro> getCachorro()
        {
            Cachorro cachorro = new Cachorro();

            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(URLAPI);

            string responseBody = await response.Content.ReadAsStringAsync();

            List<Cachorro> lista =
                JsonConvert.DeserializeObject<List<Cachorro>>(responseBody);

            cachorro = lista[0];

            return cachorro;
        }
    }


    public class RacaC
    {
        public string name { get; set; }

        public string temperament { get; set; }

        public string life_span { get; set; }

        public string bred_for { get; set; }
    }


    public class DogApi
    {
        private string URLAPI = "https://api.thedogapi.com/v1/breeds";
        private string APIKEY = "live_98a9p26vts2XQaiFteKAEaoTlSlv0izXMetJZT09rNDmPRVBRLmntEAIbHAwoZcD";

        public async Task<List<string>> GetRacas()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("x-api-key", APIKEY);

            string response =
                await client.GetStringAsync(URLAPI);

            List<RacaDog> lista =
                JsonConvert.DeserializeObject<List<RacaDog>>(response);

            return lista.Select(r => r.name).ToList();
        }
    }

    public class RacaDog
    {
        public string name { get; set; }
    }


}


