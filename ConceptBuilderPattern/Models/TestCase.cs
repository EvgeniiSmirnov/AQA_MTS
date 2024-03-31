namespace ConceptBuilderPattern.Models;

public class TestCase
{
    private List<object> _preconditions = new List<object>();
    private List<object> _steps = new List<object>();
    private List<object> _expectedResults = new List<object>();

    public void AddPrecondition(string step)
    {
        this._preconditions.Add(step);
    }

    public void AddStep(string step)
    {
        this._steps.Add(step);
    }

    public void AddExpectedResult(string step)
    {
        this._expectedResults.Add(step);
    }

    public string Preconditions()
    {
        return _preconditions.Aggregate("", (current, item) => current + (item + "\n"));
    }

    public string Steps()
    {
        return _steps.Aggregate("", (current, item) => current + (item + "\n"));
    }

    public string ExpectedResults()
    {
        return _expectedResults.Aggregate("", (current, item) => current + (item + "\n"));
    }
}