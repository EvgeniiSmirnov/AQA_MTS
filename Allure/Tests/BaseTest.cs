using System.Text;
using Allure.Net.Commons;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using Wrappers.Core;
using Wrappers.Helpers;
using Wrappers.Helpers.Configuration;
using Wrappers.Steps;

namespace Wrappers.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
[AllureNUnit]
public class BaseTest
{
    protected IWebDriver Driver { get; private set; }
    protected WaitsHelper WaitsHelper { get; private set; }

    protected UserSteps UserSteps;

    [OneTimeSetUp]
    public static void GlobalSetup()
    {
        AllureLifecycle.Instance.CleanupResultDirectory();
    }

    [SetUp]
    public void FactoryDriverTest()
    {
        Driver = new Browser().Driver;
        WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));

        UserSteps = new UserSteps(Driver);

        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
    }

    [TearDown]
    public void TearDown()
    {
        if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
        {
            Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
            byte[] screenshotBytes = screenshot.AsByteArray;

            //IWebElement test = Driver.FindElement(By.Id("sss"));
            //Screenshot screenshotElement = ((ITakesScreenshot)test).GetScreenshot();

            // Прикрепление скриншота к отчету
            // Вариант 1
            AllureLifecycle.Instance.AddAttachment("Screenshot", "image/png", screenshotBytes);

            // Вариант 2
            // AllureApi.AddAttachment("Screenshot", "image/png", screenshotBytes);
            // AllureApi.AddAttachment("data.txt", "text/plain", Encoding.UTF8.GetBytes("This os the file content."));
        }

        Driver.Quit();
    }
}