using System.Text.Json;

namespace RockPaperScissorsSpockLizard.NumberRandomizer
{
    public class HttpNumberRandomizer : INumberRandomizer
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public HttpNumberRandomizer(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<int> GetRandomNumber()
        {
            using HttpClient client = _httpClientFactory.CreateClient();

             return (await client.GetFromJsonAsync<RandomNumberModel>(
                "https://codechallenge.boohma.com/random",
                new JsonSerializerOptions(JsonSerializerDefaults.Web))).RandomNumber;
        }
    }
}
