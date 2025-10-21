using JsonPlaceHolder.Client;
using JsonPlaceHolder.Models;
using System.Net.Http.Json;


namespace JsonPlaceHolder.Client
{
    public class UserClient : BaseClient
    {
        public UserClient(HttpClient? httpClient = null) : base(httpClient)
        {

        }
        
           public async Task<List<User>> GetUsersAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<User>>("users") ?? new List<User>();
            }catch(HttpRequestException Exception)
            {
                Console.WriteLine($"Erreur HTTP :  {Exception.Message}");
                return new List<User>();
            }
            
        }
    }
}