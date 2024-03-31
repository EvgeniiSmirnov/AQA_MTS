using NativeSingleton.Pages;
using NativeSingleton.Pages.ProjectPages;

namespace NativeSingleton.Steps;

public class BaseSteps
{
    protected LoginPage? LoginPage { get; set; }
    protected DashboardPage? DashboardPage { get; set; }
    protected AddProjectPage? AddProjectPage { get; set; }
}