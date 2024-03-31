namespace ValueOfObjects.Models;

public class Project
{
    public string ProjectName { get; set; }
    public string Announcement { get; set; }
    public bool? IsShowAnnouncement { get; set; }
    public int ProjectType { get; set; }
    public bool IsTestCaseApprovals { get; set; }
    public string NewField { get; set; }
}