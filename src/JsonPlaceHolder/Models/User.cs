using System.Text.Json.Serialization;

namespace JsonPlaceHolder.Models;

public class User
{ 
    [JsonPropertyName("id")]
    public int Id { get; set; }


    [JsonPropertyName("name")]
    public required string Name { get; set; }


    [JsonPropertyName("username")]
    public required string Username { get; set; }

    [JsonPropertyName("email")]
    public required string Email { get; set; }

    [JsonPropertyName("adress")]
    public Address? Address { get; set; }

    [JsonPropertyName("phone")]
    public required string Phone { get; set; }
 
    [JsonPropertyName("website")]
    public required string Website { get; set; }

    [JsonPropertyName("company")]
    public Company? Company { get; set; }
}