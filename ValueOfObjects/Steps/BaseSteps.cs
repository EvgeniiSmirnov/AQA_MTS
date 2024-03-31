using OpenQA.Selenium;
using ValueOfObjects.Pages;
using ValueOfObjects.Pages.ProjectPages;

namespace ValueOfObjects.Steps;

public class BaseSteps(IWebDriver driver)
{
    protected readonly IWebDriver Driver = driver;

    protected LoginPage? LoginPage { get; set; }
    protected DashboardPage? DashboardPage { get; set; }
    protected AddProjectPage? AddProjectPage { get; set; }
}