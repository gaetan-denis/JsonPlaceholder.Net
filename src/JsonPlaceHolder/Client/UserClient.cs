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
            catch (HttpRequestException exception)
            {
                Console.WriteLine($"Erreur HTTP :  {exception.Message}");
                return new List<User>();
            }

        }
        /// <summary>
        /// Return a single user by ID from JSONPlaceholder API.
        /// </summary>
        /// <param name="id">The id of the user</param>
        /// <returns>A <see cref="User"/> object or null if not found.</returns>
        
         public async Task<User?> GetUserByIdAsync(int id)
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<User>($"users/{id}");
            }
            catch(HttpRequestException exception)
            {
                Console.WriteLine($"Erreur Http : {exception.Message}");
                return null;
            }
        }
    }
}