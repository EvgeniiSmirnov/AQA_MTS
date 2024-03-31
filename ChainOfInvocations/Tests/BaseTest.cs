using ChainOfInvocations.Steps;
using OpenQA.Selenium;
using ChainOfInvocations.Core;
using ChainOfInvocations.Helpers;
using ChainOfInvocations.Helpers.Configuration;
using NUnit.Framework;

namespace ChainOfInvocations.Tests;

//[Parallelizable(scope: ParallelScope.All)]
//[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    protected IWebDriver Driver { get; private set; }
    protected WaitsHelper WaitsHelper { get; private set; }
    protected NavigationSteps NavigationSteps;
    protected ProjectsSteps ProjectSteps;

    [SetUp]
    public void Setup()
    {
        Driver = new Browser().Driver;
        WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));

        NavigationSteps = new NavigationSteps(Driver);
        ProjectSteps = new ProjectsSteps(Driver);

        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}