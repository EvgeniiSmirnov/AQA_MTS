using System.Text.Json.Serialization;

namespace TestRailComplexApi.Models;

public class Links
{
    [JsonPropertyName("next")] public string Next { get; set; }
    [JsonPropertyName("prev")] public string Prev { get; set; }
}