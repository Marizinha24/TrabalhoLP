using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using static TrabalhoLP.Properties.Model.Gato;

namespace TrabalhoLP.Properties.Model
{
    public class Gato
    {
        public string id { get; set; }

        public string url { get; set; }

        public int width { get; set; }

        public int height { get; set; }

        public List<RacaGato> breeds { get; set; }


        private const string APIKEY =
            "live_AKMfFk8qpYf16buuqcdHfPZI96eLn6qPJ6MinfHuv5OKecU71M3l02FhVxbgSx2v";

        private string URLImagem =
            "https://api.thecatapi.com/v1/images/search";

        private string URLRacas =
            "https://api.thecatapi.com/v1/breeds";

        //classes auxiliares

        public class RacaGato
        {
            public string id { get; set; }

            public string name { get; set; }

            public string temperament { get; set; }

            public string life_span { get; set; }

            public string origin { get; set; }
        }

        public class ImagemGato
        {
            public string url { get; set; }
        }



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
        public async Task<Gato> GetGato()
        {
            HttpClient client = CriarClient();

            HttpResponseMessage response =
                await client.GetAsync(URLImagem);

            string responseBody =
                await response.Content.ReadAsStringAsync();

            List<Gato> lista =
                JsonConvert.DeserializeObject<List<Gato>>(responseBody);

            return lista[0];
        }


        // Buscar lista de raças
        public async Task<List<string>> GetRacas()
        {
            HttpClient client = CriarClient();

            string response =
                await client.GetStringAsync(URLRacas);

            List<RacaGato> lista =
                JsonConvert.DeserializeObject<List<RacaGato>>(response);

            return lista.Select(r => r.name).ToList();
        }

        //🔥 IMAGEM POR RAÇA (AQUI ESTÁ O IMPORTANTE)

        public async Task<string> GetImagemPorRaca(string raca)
        {
            HttpClient client = CriarClient();

            // busca todas as raças
            string responseRacas =
                await client.GetStringAsync(URLRacas);

            List<RacaGato> racas =
                JsonConvert.DeserializeObject<List<RacaGato>>(responseRacas);

            // procura raça digitada
            RacaGato racaEncontrada =
                racas.FirstOrDefault(r =>
                    r.name.ToLower().Contains(raca.ToLower()));

            if (racaEncontrada == null)
                return "";

            string breedId = racaEncontrada.id;

            // busca imagem da raça
            string responseImg =
                await client.GetStringAsync(
                    $"https://api.thecatapi.com/v1/images/search?breed_ids={breedId}");

            List<ImagemGato> imagens =
                JsonConvert.DeserializeObject<List<ImagemGato>>(responseImg);

            if (imagens == null || imagens.Count == 0)
                return "";

            return imagens[0].url;
        }
    }


    
}