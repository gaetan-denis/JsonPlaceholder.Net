namespace JsonPlaceHolder.Models;

public class Address
{
    public required string Street { get; set; }
    public required string Suite { get; set; }
    public required string City { get; set; }

    public required string ZipCode { get; set; }
    public Geo? Geo { get; set; }
}