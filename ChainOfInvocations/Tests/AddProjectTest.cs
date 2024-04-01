using NUnit.Framework;
using ChainOfInvocations.Helpers.Configuration;
using ChainOfInvocations.Pages;

namespace ChainOfInvocations.Tests;

public class AddProjectTest : BaseTest
{
    [Test]
    public void SuccessAddProjectTest()
    {
        var projectName = $"Project {new Random().Next(1, 999)}";
        NavigationSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        ProjectsPage projectsPage = ProjectSteps.AddProjects(
            projectName,
            "Announcement",
            false, // Announcement checkbox
            new Random().Next(0, 3), // Project type
            true); // Test Case Approvals checkbox

        Assert.That(projectsPage.ProjectsTable.GetCell("Project", projectName, 0).GetLink().Enabled);
    }
}