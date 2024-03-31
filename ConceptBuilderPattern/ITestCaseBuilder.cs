namespace ConceptBuilderPattern.Models;

// Интерфейс Строителя объявляет создающие методы для различных частей объектов Продуктов.
public interface ITestCaseBuilder
{
    void BuildPrecondition();

    void BuildSteps();

    void BuildExpectedResults();
}