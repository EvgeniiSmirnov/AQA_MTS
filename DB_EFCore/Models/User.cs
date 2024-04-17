using DB_EFCore.Models.Enums;

namespace DB_EFCore.Models;

public class User
{
    public UserType UserType { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
