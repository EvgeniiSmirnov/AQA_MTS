using System.Net;
using Bogus;
using NLog;
using TestRailComplexApi.Fakers;
using TestRailComplexApi.Models;

namespace TestRailComplexApi.Tests.Homework;

public class MilestonesTest : BaseApiTest
{
    private readonly Logger _logger = LogManager.GetCurrentClassLogger();
    private Project _project;
    private Milestone _milestone;
    private static Faker<Project> _faker = new ProjectFaker();
    private static Faker<Milestone> _milestoneFaker = new MilestoneFaker();

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        Project generatedProject = _faker.Generate();
        _project = CreateBaseProject(generatedProject);

        // Блок проверок
        Assert.Multiple(() =>
        {
            Assert.That(_project.Name, Is.EqualTo(generatedProject.Name));
            Assert.That(_project.Announcement, Is.EqualTo(generatedProject.Announcement));
            Assert.That(_project.SuiteMode, Is.EqualTo(generatedProject.SuiteMode));
        });
    }

    [Test]
    [Order(1)]
    public void AddMilestone()
    {
        _milestone = _milestoneFaker.Generate();

        var actualMilestone = MilestoneServices!.AddMilestone(_project.Id.ToString(), _milestone);

        Assert.Multiple(() =>
        {
            Assert.That(actualMilestone.Result.Name, Is.EqualTo(_milestone.Name));
            Assert.That(actualMilestone.Result.Description, Is.EqualTo(_milestone.Description));
        });

        _milestone = actualMilestone.Result;
        _logger.Info(_milestone.ToString());
    }

    [Test]
    [Order(2)]
    public void GetMilestone()
    {
        var actualMilestone = MilestoneServices!.GetMilestone(_milestone.ID.ToString());

        Assert.Multiple(() =>
        {
            Assert.That(actualMilestone.Result.Name, Is.EqualTo(_milestone.Name));
            Assert.That(actualMilestone.Result.Description, Is.EqualTo(_milestone.Description));
        });

        _logger.Info(actualMilestone.Result.ToString());
    }

    [Test]
    [Order(3)]
    public void UpdateMilestone()
    {
        Milestone milestoneUpdate = new Milestone
        {
            Name = "New TestName"
        };

        var actualMilestone = MilestoneServices!.UpdateMilestone(_milestone, milestoneUpdate);

        Assert.That(actualMilestone.Result.Name, Is.EqualTo(milestoneUpdate.Name));

        _milestone = actualMilestone.Result;
    }

    //[Test]
    //[Order(4)]
    //public void DeleteMilestone()
    //{
    //    var actualMilestone = MilestoneServices!.DeleteMilestone(_milestone.ID.ToString());

    //    Assert.That(actualMilestone == HttpStatusCode.OK);
    //}

    //[OneTimeTearDown]
    //public void OneTimeTearDown()
    //{
    //    Assert.That(DeleteBaseProject(_project.Id.ToString()) == HttpStatusCode.OK);
    //}
}