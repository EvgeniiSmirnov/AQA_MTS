using BuilderPattern.Models;
using NUnit.Framework;

namespace BuilderPattern.Tests;

public class ProjectTest : BaseTest
{
    [Test]
    public void SuccessfulAddProjectTest()
    {
        _navigationSteps.SuccessfulLogin(Admin);

        Project expectedProject = new Project.Builder()
            .SetProjectName("WP Test 07")
            .SetAnnouncement("Test Details")
            .SetShowAnnouncement(false)
            .SetProjectType(1)
            .Build();

        Assert.That(_projectSteps.AddProject(expectedProject).SuccessMessage.Text.Trim(),
            Is.EqualTo("Successfully added the new project."));
    }
}