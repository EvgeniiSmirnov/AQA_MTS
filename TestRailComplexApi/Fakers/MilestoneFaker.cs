using Bogus;
using TestRailComplexApi.Models;

namespace TestRailComplexApi.Fakers;

public class MilestoneFaker : Faker<Milestone>
{
    public MilestoneFaker()
    {
        RuleFor(x => x.Name, f => f.Random.AlphaNumeric(20));
        RuleFor(x => x.Description, f => f.Random.AlphaNumeric(15));
    }
}