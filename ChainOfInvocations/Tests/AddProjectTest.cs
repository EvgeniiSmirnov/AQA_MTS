using NUnit.Framework;
using ChainOfInvocations.Helpers.Configuration;
using ChainOfInvocations.Pages;

namespace ChainOfInvocations.Tests;

public class AddProjectTest : BaseTest
{
    [Test]
    public void SuccessAddProjectTest()
    {
        _navigationSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        ProjectsPage projectsPage = ProjectSteps.AddProjects(
            "Project" + new Random().Next(1,100),
            "Test",
            false,
            1,
            true);

        Assert.That(projectsPage.ProjectsTable.GetCell("Project", "Project", 0).GetLink().Enabled);
    }
}