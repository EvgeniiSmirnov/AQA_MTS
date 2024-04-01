using BuilderHomework.Models;
using BuilderHomework.Pages;
using BuilderHomework.Pages.ProjectPages;
using OpenQA.Selenium;

namespace BuilderHomework.Steps;

public class ProjectsSteps(IWebDriver driver) : BaseSteps(driver)
{
    public ProjectsPage AddProject(Project project)
    {
        DashboardPage dashboardPage = new DashboardPage(Driver);

        return dashboardPage
                .SidebarProjectsAddButtonClick()
                .InputProjectNameValue(project.ProjectName)
                .InputAnnouncementValue(project.Announcement)
                .SetShowAnnouncementCheckbox(project.IsShowAnnouncement)
                .SetProjectType(project.ProjectType)
                .SetCaseApprovalsCheckbox(project.IsTestCaseApprovals)
                .AddButtonClick();
    }

    public ProjectMilestonesPage AddMilestone(Milestone milestone)
    {
        ProjectPage projectPage = new ProjectPage(Driver);

        return projectPage
            .AddMilestoneButtonClick()
            .InputMilestoneName(milestone.MilestoneName)
            .InputReference(milestone.References)
            .InputDescription(milestone.Description)
            .SetStartDate(milestone.StartDate)
            .SetEndDate(milestone.EndDate)
            .SetCheckbomMilestoneCompleted(milestone.IsMilestoneCompleted)
            .AddButtonClick();
    }
}