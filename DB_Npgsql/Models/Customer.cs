namespace DB_Npgsql.Models;

public record Customer
{
    public int? Id { get; set; }
    public string? Firstname { get; set; }
    public string? Lastname { get; set; }
    public string? Email { get; set; }
    public int? Age { get; set; }
}