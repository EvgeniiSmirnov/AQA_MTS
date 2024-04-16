using System.Text.Json.Serialization;

namespace TestRailComplexApi.Models;

public class Case
{
    [JsonPropertyName("title")] public string Title { get; set; }
    [JsonPropertyName("id")] public int Id { get; set; }
}