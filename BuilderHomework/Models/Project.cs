namespace BuilderHomework.Models;

public class Project
{
    public string ProjectName { get; }
    public string Announcement { get; }
    public bool IsShowAnnouncement { get; }
    public int ProjectType { get; }
    public bool IsTestCaseApprovals { get; }

    private Project(string projectName, string announcement, bool isShowAnnouncement, int projectType, bool isTestCaseApprovals)
    {
        ProjectName = projectName;
        Announcement = announcement;
        IsShowAnnouncement = isShowAnnouncement;
        ProjectType = projectType;
        IsTestCaseApprovals = isTestCaseApprovals;
    }

    public class Builder
    {
        public string ProjectName { get; set; }
        public string Announcement { get; set; }
        public bool IsShowAnnouncement { get; set; }
        public int ProjectType { get; set; }
        public bool IsTestCaseApprovals { get; set; }

        //public Builder SetID(string id)
        //{
        //    Id = id;
        //    return this;
        //}

        public Builder SetProjectName(string projectName)
        {
            ProjectName = projectName;
            return this;
        }

        public Builder SetAnnouncement(string announcement)
        {
            Announcement = announcement;
            return this;
        }

        public Builder SetCheckboxShowAnnouncement(bool isShowAnnouncement)
        {
            IsShowAnnouncement = isShowAnnouncement;
            return this;
        }

        public Builder SetProjectType(int projectType)
        {
            ProjectType = projectType;
            return this;
        }

        public Builder SetCheckboxTestCaseApprovals(bool isTestCaseApprovals)
        {
            IsTestCaseApprovals = isTestCaseApprovals;
            return this;
        }

        public Project Build()
        {
            if (string.IsNullOrWhiteSpace(ProjectName))
                throw new InvalidOperationException("MilestoneName can not be null");

            return new Project(
                ProjectName,
                Announcement,
                IsShowAnnouncement,
                ProjectType,
                IsTestCaseApprovals);
        }
    }
}