using ChainOfInvocations.Pages;
using ChainOfInvocations.Pages.ProjectPages;
using OpenQA.Selenium;

namespace ChainOfInvocations.Steps;

public class ProjectsSteps(IWebDriver driver) : BaseSteps(driver)
{
    public ProjectsPage AddProjects(string projectName, string announcement, bool checkAnnouncement, int suiteMode, bool checkCaseStatuses)
    {
        DashboardPage dashboardPage = new DashboardPage(Driver);

        return dashboardPage
            .ClickSidebarProjectsAddButton()
            .InputNameValue(projectName)
            .InputAnnouncementValue(announcement)
            .CheckShowAnnouncementCheckbox()
            .ChooseProjectType(suiteMode)
            .CheckCaseApprovalsCheckbox()
            .ClickAddButton();
    }
}