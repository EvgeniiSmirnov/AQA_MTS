using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Resources;
using NUnit.Framework;
using OpenQA.Selenium;
using ValueOfObjects.Core;
using ValueOfObjects.Helpers;
using ValueOfObjects.Helpers.Configuration;
using ValueOfObjects.Models;
using ValueOfObjects.Steps;

namespace ValueOfObjects.Tests;

//[Parallelizable(scope: ParallelScope.All)]
//[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    protected IWebDriver Driver { get; private set; }

    protected NavigationSteps _navigationSteps;
    protected ProjectSteps _projectSteps;

    protected User Admin { get; private set; }

    protected Project project;
    protected Project project2;

    [OneTimeSetUp]
    public void OneTimeSetup()
    {
        project = JsonHelper.ProjectFromJson(@"Resources\project_en.json");
        project2 = JsonHelper.ProjectFromJson(@"Resources\project_ru.json");
    }

    [SetUp]
    public void Setup()
    {
        Driver = new Browser().Driver;

        _navigationSteps = new NavigationSteps(Driver);
        _projectSteps = new ProjectSteps(Driver);

        Admin = new User
        {
            Email = Configurator.AppSettings.Username,
            Password = Configurator.AppSettings.Password
        };

        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}