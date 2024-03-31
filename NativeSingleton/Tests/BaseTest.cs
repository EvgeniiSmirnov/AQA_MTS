using NativeSingleton.Steps;

namespace NativeSingleton.Tests;

public class BaseTest
{
    protected NavigationSteps NavigationSteps => new NavigationSteps();
    protected ProjectSteps ProjectSteps => new ProjectSteps();
}