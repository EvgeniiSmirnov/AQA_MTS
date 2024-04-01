using NUnit.Framework;
using ValueOfObjects.Models;
using ValueOfObjects.Pages.ProjectPages;
using ValueOfObjects.Steps;

namespace ValueOfObjects.Tests;

public class AddProjectTest : BaseTest
{
    [Test]
    public void AddProjectTask2Test()
    {
        var projectName = $"Project {new Random().Next(1, 999)}";
        _navigationSteps.SuccessfulLogin(Admin);              

        Project expectedProject = new Project()
        {
            ProjectName = projectName,
            Announcement = "Announcement",
            IsShowAnnouncement = false,
            ProjectType = new Random().Next(0, 3),
            IsTestCaseApprovals = true
        };

        Assert.That(_projectSteps.AddProject(expectedProject).SuccessMessage.Text.Trim(),
            Is.EqualTo("Successfully added the new project."));
    }
}