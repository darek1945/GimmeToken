using System.Net;

namespace GiveMeToken.Models;

public class Account
{
    public required string Endpoint { get; set; }
    public required string Secret { get; set; }
    public string Token { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    
}