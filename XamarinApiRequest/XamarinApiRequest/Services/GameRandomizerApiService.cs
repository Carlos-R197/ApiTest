using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XamarinApiRequest.Models;
using Newtonsoft.Json;

namespace XamarinApiRequest.Services
{
    public class GameRandomizerApiService : IGameRandomizerApiService
    {
        public async Task<Game> GetRandomAsync()
        {
            Game game = null;
            var client = new HttpClient();
            var response = await client.GetAsync("https://api.rawg.io/api/genres?key=9b88a4289b784c19b41aff2c40764c6a");

            if (response.IsSuccessStatusCode)
            {
                var example = JsonConvert.DeserializeObject<Example>(await response.Content.ReadAsStringAsync());
                //get first game of first result
                game = example.results[0].games[0];
            }

            return game;
        }
    }
}
