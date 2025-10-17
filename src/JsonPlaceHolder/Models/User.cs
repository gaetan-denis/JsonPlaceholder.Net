namespace JsonPlaceHolder.Models;

public class User
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Username { get; set; }
    public required string Email { get; set; }

    public Address? Address { get; set; }

    public required string Phone { get; set; }
    public required string Website { get; set; }

    public Company? Company { get; set; }
}