using OpenQA.Selenium;
using ValueOfObjects.Pages;
using ValueOfObjects.Pages.ProjectPages;

namespace ValueOfObjects.Steps;

public class BaseSteps(IWebDriver driver)
{
    protected readonly IWebDriver Driver = driver;

    public LoginPage? LoginPage { get; set; }
    public DashboardPage? DashboardPage { get; set; }
    public AddProjectPage? AddProjectPage { get; set; }
}