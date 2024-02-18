using PageObjectStepsSauceDemo.Core;
using PageObjectStepsSauceDemo.Helpers;
using PageObjectStepsSauceDemo.Helpers.Configuration;
using OpenQA.Selenium;
using PageObjectStepsSauceDemo.Steps;

namespace PageObjectStepsSauceDemo.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    public IWebDriver Driver { get; private set; }
    public WaitsHelper WaitsHelper { get; private set; }

    protected NavigationSteps NavigationSteps;

    [SetUp]
    public void Setup()
    {
        Driver = new Browser().Driver;
        WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
        
        // Инициализация Steps
        NavigationSteps = new(Driver);
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}