using System.Net.Http.Json;


namespace JsonPlaceHolder.Client
{
    public class UserClient(HttpClient? httpClient = null) : BaseClient(httpClient), BaseClient
    {
        /// <summary>
        /// Return list of all users from JSONPlaceHolder Api.
        /// </summary>
        /// <returns>A list of <see cref="Users" > object</returns>
        static public async Task<List<User>> GetUsersAsync()
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