using BuilderPattern.Pages;
using BuilderPattern.Pages.ProjectPages;
using OpenQA.Selenium;

namespace BuilderPattern.Steps;

public class BaseSteps(IWebDriver driver)
{
    protected readonly IWebDriver Driver = driver;

    public LoginPage? LoginPage { get; set; }
    public DashboardPage? DashboardPage { get; set; }
    public AddProjectPage? AddProjectPage { get; set; }
}