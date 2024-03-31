using ConceptBuilderPattern.Models;

namespace ConceptBuilderPattern;

public class BuilderTest
{
    [Test]
    public void SimpleTest()
    {
        var director = new Director();
        var builder = new TestCaseBuilder();
        director.Builder = builder;

        Console.WriteLine("General TestCase");
        director.BuildGeneralTestCase();
        var builderResult = builder.GetTestCase();
        Console.WriteLine(builderResult.Steps());

        Console.WriteLine("Full TestCase");
        director.BuildFullTestCase();
        builderResult = builder.GetTestCase();
        Console.WriteLine(builderResult.Preconditions());
        Console.WriteLine(builderResult.Steps());
        Console.WriteLine(builderResult.ExpectedResults());

        // Помните, что паттерн Строитель можно использовать без класса Директор.
        Console.WriteLine("Custom TestCase:");
        builder.BuildSteps();
        builder.BuildExpectedResults();
        builderResult = builder.GetTestCase();
        Console.WriteLine(builderResult.Steps());
        Console.WriteLine(builderResult.ExpectedResults());
    }
}