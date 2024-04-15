using Bogus;
using TestRailComplexApi.Models;

namespace TestRailComplexApi.Fakers;

public class ProjectFaker : Faker<Project>
{
    public ProjectFaker()
    {
        RuleFor(x => x.Name, f => "Project " + f.Random.AlphaNumeric(10));
        RuleFor(x => x.Announcement, f => f.Random.Words(5));
        RuleFor(x => x.SuiteMode, f => f.Random.Number(1, 3));
        RuleFor(x => x.ShowAnnouncement, f => f.Random.Bool());
    }
}