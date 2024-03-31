using NativeSingleton.Core;
using NativeSingleton.Helpers.Configuration;
using NativeSingleton.Steps;
using NUnit.Framework;

namespace NativeSingleton.Tests;

[SetUpFixture]
public class MySetUpFixture
{
    [OneTimeSetUp]
    public void OneTimeSetup()
    {
        BrowserSingleton.GetInstance().GetDriver().Navigate().GoToUrl(Configurator.AppSettings.URL);
        new NavigationSteps().SuccessfulLoginByAdmin();
    }

    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
        BrowserSingleton.GetInstance().CloseDriver();
    }
}