using JsonPlaceHolder.Models;
using System.Net.Http.Json;

namespace JsonPlaceHolder.Client
{
    public class BaseClient
    {
        // S'il existe déjà une instance HttpClient on l'utilse sinon on en crée une nouvelle.
        private readonly HttpClient _httpClient;
        private readonly Uri _baseAddress = new("https://jsonplaceholder.typicode.com/");

        // Le constructeur peut prendre une variable de type HttpClient, s'il ne le fait pas _httpClient sera défini comme étant null.
        public BaseClient(HttpClient? httpClient = null)
        {
            /* 
            * Si httpClient existe → _httpClient = httpClient
            * Si httpClient est null → _httpClient = new HttpClient()
            */
            _httpClient = httpClient ?? new HttpClient();
            _httpClient.BaseAddress = _baseAddress;
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<User>>("users") ?? new List<User>();
        }
    }
}