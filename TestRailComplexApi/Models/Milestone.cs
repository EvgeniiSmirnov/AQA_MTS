using System.Text.Json.Serialization;

namespace TestRailComplexApi.Models;

public class Milestone
{
    [JsonPropertyName("name")] public string Name { get; set; }
    [JsonPropertyName("description")] public string Description { get; set; }
    [JsonPropertyName("id")] public int ID { get; set; }
}