namespace ConceptBuilderPattern.Models;

public class TestCaseBuilder : ITestCaseBuilder
{
    private TestCase _testCase = new TestCase();

    // Новый экземпляр строителя должен содержать пустой объект продукта,
    // который используется в дальнейшей сборке.
    public TestCaseBuilder()
    {
        this.Reset();
    }

    public void Reset()
    {
        this._testCase = new TestCase();
    }


    // Все этапы производства работают с одним и тем же экземпляром
    // продукта.
    public void BuildPrecondition()
    {
        this._testCase.AddPrecondition("Test Precondition 1");
        this._testCase.AddPrecondition("Test Precondition 2");
    }

    public void BuildSteps()
    {
        this._testCase.AddStep("Test Step 1");
        this._testCase.AddStep("Test Step 2");
    }

    public void BuildExpectedResults()
    {
        this._testCase.AddExpectedResult("Test Expected Result 1");
        this._testCase.AddExpectedResult("Test Expected Result 2");
    }

    public TestCase GetTestCase()
    {
        TestCase result = this._testCase;

        this.Reset();

        return result;
    }
}