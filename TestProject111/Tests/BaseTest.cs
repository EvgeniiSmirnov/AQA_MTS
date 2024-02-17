using OpenQA.Selenium;
using TestProject111.Core;
using TestProject111.Helpers.Configuration;
using TestProject111.Helpers;
using TestProject111.Steps;

namespace TestProject111.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    protected IWebDriver Driver { get; private set; }
    protected WaitsHelper WaitsHelper { get; private set; }

    protected LoginSteps LoginSteps;
    //protected CatalogSteps CatalogSteps;
    //protected CartSteps CartSteps;

    [SetUp]
    public void Setup()
    {
        Driver = new Browser().Driver;
        WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));

        // Инициализация Steps
        LoginSteps = new LoginSteps(Driver);
        //CatalogSteps = new CatalogSteps(Driver);
        //CartSteps = new CartSteps(Driver);
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}