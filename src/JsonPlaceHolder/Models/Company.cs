using System.Text.Json.Serialization;

namespace JsonPlaceHolder.Models;

public class Company
{

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("catchPhrase")]
    public required string CatchPhrase { get; set; }
    
      [JsonPropertyName("bs")]
    public required string Bs { get; set; }

}