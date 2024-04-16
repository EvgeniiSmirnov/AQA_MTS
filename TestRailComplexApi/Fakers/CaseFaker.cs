using Bogus;
using TestRailComplexApi.Models;

namespace TestRailComplexApi.Fakers;

public class CaseFaker : Faker<Case>
{
    public CaseFaker()
    {
        RuleFor(x => x.Title, f => f.Random.AlphaNumeric(20));
    }
}