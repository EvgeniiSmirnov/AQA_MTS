using System.Text.Json.Serialization;

namespace ValueOfObjects.Models.Homework;

public class Milestone
{
    [JsonPropertyName("id")] public int ID { get; set; }
    [JsonPropertyName("name")] public required string MilestoneName { get; set; }
    [JsonPropertyName("description")] public string Description { get; set; }
    [JsonPropertyName("start_on")] public DateTime StartOn { get; set; }
    [JsonPropertyName("started_on")] public DateTime StartedOn { get; set; }
    [JsonPropertyName("is_started")] public bool IsStarted { get; set; }
    [JsonPropertyName("due_on")] public DateTime DueOn { get; set; }
    [JsonPropertyName("is_completed")] public bool IsCompleted { get; set; }
    [JsonPropertyName("completed_on")] public DateTime CompletedOn { get; set; }
    [JsonPropertyName("parent_id")] public int ParentId { get; set; }
    [JsonPropertyName("project_id")] public int ProjectId { get; set; }
    [JsonPropertyName("refs")] public string Refs { get; set; }
    [JsonPropertyName("url")] public string URL { get; set; }
    [JsonPropertyName("milestones")] public Milestones[] Milestones { get; set; }
}
public class Milestones
{
    [JsonPropertyName("id")] public int ID { get; set; }
}