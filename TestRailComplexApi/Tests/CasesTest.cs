using System.Net;
using Bogus;
using NLog;
using TestRailComplexApi.Fakers;
using TestRailComplexApi.Models;

namespace TestRailComplexApi.Tests.Homework;

public class CasesTest : BaseApiTest
{
    private readonly Logger _logger = LogManager.GetCurrentClassLogger();
    private Project _project;
    private Section _section;
    private Case _case;
    private static Faker<Project> _projectFaker = new ProjectFaker();
    private static Faker<Section> _sectionFaker = new SectionsFaker();
    private static Faker<Case> _caseFaker = new CaseFaker();

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        Project generatedProject = _projectFaker.Generate();
        Section generatedSection = _sectionFaker.Generate();

        _project = CreateBaseProject(generatedProject);

        Assert.Multiple(() =>
        {
            Assert.That(_project.Name, Is.EqualTo(generatedProject.Name));
            Assert.That(_project.Announcement, Is.EqualTo(generatedProject.Announcement));
            Assert.That(_project.SuiteMode, Is.EqualTo(generatedProject.SuiteMode));
        });

        _section = CreateBaseSection(_project.Id.ToString(), generatedSection);

        Assert.Multiple(() =>
        {
            Assert.That(_section.Name, Is.EqualTo(generatedSection.Name));
            Assert.That(_section.Description, Is.EqualTo(generatedSection.Description));
        });

        _logger.Info($"Prpject ID: {_project.Id} Section ID: {_section.Id}");
    }

    [Test]
    [Order(1)]
    public void AddCase()
    {
        _case = _caseFaker.Generate();
        Thread.Sleep(1000);

        var actualCase = CaseServices!.AddCase(_section.Id.ToString(), _case);

        Assert.That(actualCase.Result.Title, Is.EqualTo(_case.Title));

        _case = actualCase.Result;
        _logger.Info(_case.ToString());
    }

    [Test]
    [Order(2)]
    public void GetCase()
    {
        var actualCase = CaseServices!.GetCase(_case.Id.ToString());

        Assert.Multiple(() =>
        {
            Assert.That(actualCase.Result.Title, Is.EqualTo(_case.Title));
            Assert.That(actualCase.Result.Id, Is.EqualTo(_case.Id));
        });

        _logger.Info(actualCase.Result.ToString());
    }

    [Test]
    [Order(3)]
    public void UpdateCase()
    {
        Case newCase = new Case
        {
            Title = "New Title",
        };

        var actualCase = CaseServices!.UpdateCase(_case, newCase);

        Assert.Multiple(() =>
        {
            Assert.That(actualCase.Result.Title, Is.EqualTo(newCase.Title));
            Assert.That(actualCase.Result.Id, Is.EqualTo(_case.Id));
        });

        _case = actualCase.Result;
        _logger.Info(actualCase.Result.ToString());
    }

    [Test]
    [Order(4)]
    public void MoveCase()
    {
        Section newSection = _sectionFaker.Generate();
        var actualSection = CreateBaseSection(_project.Id.ToString(), newSection);

        Assert.Multiple(() =>
        {
            Assert.That(actualSection.Name, Is.EqualTo(newSection.Name));
            Assert.That(actualSection.Description, Is.EqualTo(newSection.Description));
        });

        var actualCase =
            CaseServices!.MoveCasesToSection(_section.Id.ToString(), actualSection.Id.ToString(), _case.Id.ToString());

        Assert.That(actualCase == HttpStatusCode.OK);
    }

    //[Test]
    //[Order(5)]
    //public void DeleteCase()
    //{
    //    var actualCase = CaseServices!.DeleteCase(_case.Id.ToString());

    //    Assert.That(actualCase == HttpStatusCode.OK);
    //}

    //[OneTimeTearDown]
    //public void OneTimeTearDown()
    //{
    //    Assert.That(DeleteBaseProject(_project.Id.ToString()) == HttpStatusCode.OK);
    //}
}