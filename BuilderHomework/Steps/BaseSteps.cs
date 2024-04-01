using BuilderHomework.Pages;
using BuilderHomework.Pages.ProjectPages;
using OpenQA.Selenium;

namespace BuilderHomework.Steps;

public class BaseSteps(IWebDriver driver)
{
    protected readonly IWebDriver Driver = driver;

    protected LoginPage? LoginPage { get; set; }
    protected DashboardPage? DashboardPage { get; set; }
    protected AddProjectPage? AddProjectPage { get; set; }
}