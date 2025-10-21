using System.Text.Json.Serialization;

namespace JsonPlaceHolder.Models;

public class Address
{

    [JsonPropertyName("street")]
    public required string Street { get; set; }

    [JsonPropertyName("suite")]
    public required string Suite { get; set; }

    [JsonPropertyName("city")]
    public required string City { get; set; }

    [JsonPropertyName("zipcode")]
    public required string ZipCode { get; set; }

    [JsonPropertyName("geo")]
    public Geo? Geo { get; set; }
}