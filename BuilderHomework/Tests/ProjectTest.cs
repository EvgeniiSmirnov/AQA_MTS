using OpenQA.Selenium;
using NUnit.Framework;
using BuilderHomework.Steps;
using BuilderHomework.Pages;
using BuilderHomework.Models;
using BuilderHomework.Elements;

namespace BuilderHomework.Tests;

public class ProjectTest : BaseTest
{
    [Test]
    public void AddProjectTest()
    {
        NavigationSteps.SuccessfulLogin(Admin);

        Project project = new Project.Builder()
            .SetProjectName($"Project {new Random().Next(1000)}")
            .SetAnnouncement("Announcement text")
            .SetCheckboxShowAnnouncement(false)
            .SetProjectType(new Random().Next(0, 3))
            .SetCheckboxTestCaseApprovals(true)
            .Build();

        ProjectsPage projectsPage = ProjectsSteps.AddProject(project);

        Assert.That(projectsPage.ProjectsTable.GetCell("Project", project.ProjectName, 0).GetLink().Enabled);
    }

    [Test]
    public void AddMilestoneTest()
    {
        NavigationSteps.SuccessfulLogin(Admin);

        ProjectsPage projectsPage = new ProjectsPage(Driver, true);

        TableCell tableCell = projectsPage.ProjectsTable.GetCell("Project", "ProjectProject", "Project");
        tableCell.GetOverviewLink().Click();

        Milestone milestone = new Milestone.Builder()
            .SetMilestoneName($"ProjectMilestone {new Random().Next(1000)}")
            .SetReferences("Reference text")
            //.SetParent(1)
            .SetDescription("Description text")
            .SetStartDate(1)
            .SetEndDate(20)
            .SetCheckboxMilestoneCompleted(true)
            .Build();

        ProjectsSteps.AddMilestone(milestone);

        Assert.That(WaitsHelper.WaitForExists(By.XPath($"//a[contains(text(),'{milestone.MilestoneName}')]")).Enabled);

    }
}