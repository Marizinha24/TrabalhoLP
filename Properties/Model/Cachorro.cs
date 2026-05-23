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

        // nada abre sem isso, se for mudar pega a chave
        private const string APIKEY =
            "live_98a9p26vts2XQaiFteKAEaoTlSlv0izXMetJZT09rNDmPRVBRLmntEAIbHAwoZcD";

        private string URLImagem =
            "https://api.thedogapi.com/v1/images/search";

        private string URLRacas =
            "https://api.thedogapi.com/v1/breeds";

        // CLASSES AUXILIARES
        public class RacaCachorro
        {
            public int id { get; set; }

            public string name { get; set; }

            public string temperament { get; set; }

            public string life_span { get; set; }

            public string bred_for { get; set; }
        }

        public class ImagemDog
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


        // IMAGEM ALEATÓRIA
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


        // LISTA DE RAÇAS
        public async Task<List<string>> GetRacas()
        {
            HttpClient client = CriarClient();

            string response =
                await client.GetStringAsync(URLRacas);

            List<RacaCachorro> lista =
                JsonConvert.DeserializeObject<List<RacaCachorro>>(response);

            return lista.Select(r => r.name).ToList();
        }


        //  IMAGEM POR RAÇA (não mexe)
        public async Task<string>GetImagemPorRaca(string raca)
        {
            HttpClient client = CriarClient();


            // BUSCA RAÇAS
            string respostaRacas = await client.GetStringAsync( URLRacas);


            List<RacaCachorro> racas = JsonConvert.DeserializeObject  <List<RacaCachorro>>(  respostaRacas);


            // procura raça exata
            RacaCachorro racaEncontrada =  racas.FirstOrDefault(r =>  r.name.Trim().ToLower()   == raca.Trim().ToLower());


            if (racaEncontrada == null)
            {
                return "";
            }


            // imagem pela raça
            string urlImagem =
                $"https://api.thedogapi.com/v1/images/search?breed_ids={racaEncontrada.id}";


            string respostaImagem =
                await client.GetStringAsync(
                    urlImagem);


            List<ImagemDog> imagens = JsonConvert.DeserializeObject <List<ImagemDog>>( respostaImagem);


            if (imagens == null ||
                imagens.Count == 0)
            {
                return "";
            }


            return imagens[0].url;
        }

    }
}