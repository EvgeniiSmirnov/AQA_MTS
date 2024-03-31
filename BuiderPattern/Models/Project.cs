namespace BuilderPattern.Models;

public class Project
{
    public string ID { get; }
    public string ProjectName { get; }
    public string Announcement { get; }
    public bool? IsShowAnnouncement { get; }
    public int ProjectType { get; }
    public bool IsTestCaseApprovals { get; }
    public DateTime CreateDate { get; }

    private Project(string id, string projectName, string announcement, bool? isShowAnnouncement, int projectType,
        bool isTestCaseApprovals, DateTime createDate)
    {
        ID = id;
        ProjectName = projectName;
        Announcement = announcement;
        IsShowAnnouncement = isShowAnnouncement;
        ProjectType = projectType;
        IsTestCaseApprovals = isTestCaseApprovals;
        CreateDate = createDate;
    }

    public class Builder
    {
        private string ID { get; set; }
        private string ProjectName { get; set; }
        private string Announcement { get; set; }
        private bool? IsShowAnnouncement { get; set; }
        private int ProjectType { get; set; }
        private bool IsTestCaseApprovals { get; set; }
        private DateTime CreateDate { get; set; }

        // Методы для установки значений полей и возвращения Builder'а для дальнейшего цепочного вызова
        public Builder SetID(string id)
        {
            ID = id;
            return this;
        }

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

        public Builder SetShowAnnouncement(bool flag)
        {
            IsShowAnnouncement = flag;
            return this;
        }

        public Builder SetTestCaseApprovals(bool flag)
        {
            IsTestCaseApprovals = flag;
            return this;
        }

        public Builder SetCreateDate(DateTime date)
        {
            CreateDate = date;
            return this;
        }

        public Builder SetProjectType(int type)
        {
            ProjectType = type;
            return this;
        }

        // Метод для построения объекта Project
        public Project Build()
        {
            // Валидация полей
            if (string.IsNullOrEmpty(ProjectName))
                throw new InvalidOperationException("Name must be set");

            return new Project(ID, ProjectName, Announcement, IsShowAnnouncement, ProjectType,
                IsTestCaseApprovals, CreateDate);
        }
    }
}