using NativeSingleton.Models;
using NUnit.Framework;

namespace NativeSingleton.Tests;

[TestFixture]
public class ProjectTest : BaseTest
{
    [Test]
    public void SuccessfulAddProjectTest()
    {
        Project expectedProject = new Project()
        {
            ProjectName = "WP Test 01",
            Announcement = "Test Details",
            IsShowAnnouncement = false,
            ProjectType = 1
        };

        Assert.That(ProjectSteps.AddProject(expectedProject).SuccessMessage.Text.Trim(),
            Is.EqualTo("Successfully added the new project."));
    }
}