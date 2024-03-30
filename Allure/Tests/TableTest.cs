using OpenQA.Selenium;
using Wrappers.Elements;
using Wrappers.Helpers.Configuration;
using Wrappers.Pages;
using Wrappers.Pages.ProjectPages;
using Wrappers.Steps;

namespace Wrappers.Tests;

public class TableTest : BaseTest
{
    [Test]
    public void AddProjectCorrectTest()
    {
        UserSteps
            .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password)
            .AddProjectButton.Click();

        ProjectsPage projectsPage = new ProjectsPage(Driver, true);
        TableCell tableCell = projectsPage.ProjectsTable.GetCell("Project", "Test2", "Project");
        tableCell.GetLink().Click();
    }
}