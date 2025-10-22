using System.Text.Json.Serialization;

namespace JsonPlaceHolder.Models;

public class Geo
{
    [JsonPropertyName("lat")]
    public required string Lat { get; set; }

    [JsonPropertyNameAttribute("lng")]
    public required string Lng { get; set; }
}