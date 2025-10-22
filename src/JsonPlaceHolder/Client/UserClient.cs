using System.Net.Http.Json;


namespace JsonPlaceHolder.Client
{
    public class UserClient : BaseClient
    {
        public UserClient(HttpClient ? httpClient=null) : base(httpClient)
        {
            
        }
        /// <summary>
        /// Return list of all users from JSONPlaceHolder Api.
        /// </summary>
        /// <returns>A list of <see cref="User" > object</returns>
        public async Task<List<User>> GetUsersAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<User>>("users") ?? new List<User>();
            }
            catch (HttpRequestException Exception)
            {
                Console.WriteLine($"Erreur HTTP :  {Exception.Message}");
                return new List<User>();
            }

        }
        
         public async Task<User?> GetUserByIdAsync(int id)
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<User>($"users/{id}");
            }
            catch(HttpRequestException Exception)
            {
                Console.WriteLine($"Erreur Http : {Exception.Message}");
                return null;
            }
        }
    }
}