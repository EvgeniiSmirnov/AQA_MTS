using NativeSingleton.Core;
using NativeSingleton.Helpers;
using NativeSingleton.Helpers.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace NativeSingleton.Pages;

public abstract class BasePage : LoadableComponent<BasePage>
{
    protected IWebDriver Driver { get; }
    protected WaitsHelper WaitsHelper { get; private set; }

    protected BasePage(bool openByURL = false)
    {
        Driver = BrowserSingleton.GetInstance().GetDriver();
        WaitsHelper = new WaitsHelper();

        if (openByURL) Load();
    }

    protected abstract string GetEndpoint();

    protected override void ExecuteLoad()
    {
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL + GetEndpoint());
    }
}