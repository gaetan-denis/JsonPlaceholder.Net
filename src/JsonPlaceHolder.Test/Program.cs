using JsonPlaceHolder.Client;
using JsonPlaceHolder.Models;

class Program
{
    static async Task Main()
    {
        var client = new BaseClient();
        var users = await client.GetUsersAsync();

        foreach (var user in users)
        {
            Console.WriteLine("Id: " + user.Id + ";");
            Console.WriteLine("Name: " + user.Name + ";");
            Console.WriteLine("Username: " + user.Username + ";");
            Console.WriteLine("Email: " + user.Email + ";");
            Console.WriteLine("Adress: Street : " + (user.Address?.Street ?? "N/A") + "; " + (user.Address?.Suite ?? "N/A") + "; City : " + (user.Address?.City ?? "N/A") + "; ZipCode : " + (user.Address?.ZipCode ?? "N/A") + "; Latitude : " + (user.Address?.Geo?.Lat ?? "N/A") + "; Longitude : " + (user.Address?.Geo?.Lng ?? "N/A") + ";");
            Console.WriteLine("Phone: " + user.Phone + ";");
            Console.WriteLine("Website: " + user.Website + ";");
            Console.WriteLine("Company: Name : " + (user.Company?.Name ?? "N/A") + "; Catch phrase : " + (user.Company?.CatchPhrase ?? "N/A") + "; Business jargon : " + (user.Company?.Bs ?? "N/A") + ";");
            Console.WriteLine("-------------------------");
        }
    }
}