using PageObjectSimpleSauceDemo.Core;
using PageObjectSimpleSauceDemo.Helpers;
using PageObjectSimpleSauceDemo.Helpers.Configuration;
using OpenQA.Selenium;

namespace PageObjectSimpleSauceDemo.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    public IWebDriver Driver { get; private set; }
    public WaitsHelper WaitsHelper { get; private set; }

    [SetUp]
    public void Setup()
    {
        Driver = new Browser().Driver;
        WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}