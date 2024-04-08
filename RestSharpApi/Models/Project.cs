using System.Text.Json.Serialization;

namespace RestSharpApi.Models;

public class Project
{
    [JsonPropertyName("id")] public int Id { get; set; }
    [JsonPropertyName("name")] public String Name { get; set; }
    [JsonPropertyName("announcement")] public String Announcement { get; set; }
    [JsonPropertyName("show_announcement")] public bool IsShowAnnouncement { get; set; }
    [JsonPropertyName("suite_mode")] public int SuiteMode { get; set; }

    public override string ToString()
    {
        return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Announcement)}: {Announcement}, " +
               $"{nameof(IsShowAnnouncement)}: {IsShowAnnouncement}, {nameof(SuiteMode)}: {SuiteMode}";
    }

    protected bool Equals(Project other)
    {
        return Name == other.Name && Announcement == other.Announcement &&
               IsShowAnnouncement == other.IsShowAnnouncement && SuiteMode == other.SuiteMode;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Project)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Announcement, IsShowAnnouncement, SuiteMode);
    }
}