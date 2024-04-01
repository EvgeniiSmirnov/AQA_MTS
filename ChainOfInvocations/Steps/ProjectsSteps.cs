using ChainOfInvocations.Pages;
using OpenQA.Selenium;

namespace ChainOfInvocations.Steps;

public class ProjectsSteps(IWebDriver driver) : BaseSteps(driver)
{
    public ProjectsPage AddProjects(string projectName, string announcement, bool checkAnnouncement, int suiteMode, bool checkCaseStatuses)
    {
        DashboardPage dashboardPage = new(Driver);

        return dashboardPage
            .SidebarProjectsAddButtonClick()
            .InputProjectName(projectName)
            .InputAnnouncement(announcement)
            .SetCheckboxShowAnnouncement(checkAnnouncement)
            .SetProjectType(suiteMode)
            .SetCheckboxTestCaseApprovals(checkCaseStatuses)
            .MainAddButtonClick();
    }
}