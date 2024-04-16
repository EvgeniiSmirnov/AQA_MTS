using System.Net;
using Bogus;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using NLog;
using TestRailComplexApi.Fakers;
using TestRailComplexApi.Models;

namespace TestRailComplexApi.Tests.Homework;

public class Task3 : BaseApiTest
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

        Assert.Multiple(() =>
        {
            Assert.That(_project.Name, Is.EqualTo(generatedProject.Name));
            Assert.That(_project.Announcement, Is.EqualTo(generatedProject.Announcement));
            Assert.That(_project.SuiteMode, Is.EqualTo(generatedProject.SuiteMode));
        });
    }

    [Test]
    public void AddMilestone()
    {
        JSchema schema = JSchema.Parse(File.ReadAllText(@"Resources/schema.json"));

        _milestone = _milestoneFaker.Generate();

        var result = MilestoneServices!.AddMilstoneForFullCheck(_project.Id.ToString(), _milestone);

        Assert.That(result.Result.StatusCode, Is.EqualTo(HttpStatusCode.OK));

        Milestone responseBody = JsonConvert.DeserializeObject<Milestone>(result.Result.Content);

        _logger.Info($"Response: {result.Result.Content}");

        Assert.Multiple((() =>
        {
            Assert.That(responseBody.Name, Is.EqualTo(_milestone.Name));
            Assert.That(responseBody.Description, Is.EqualTo(_milestone.Description));
            Assert.That(JObject.Parse(result.Result.Content).IsValid(schema));
        }));
    }

    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
        Assert.That(DeleteBaseProject(_project.Id.ToString()) == HttpStatusCode.OK);
    }
}