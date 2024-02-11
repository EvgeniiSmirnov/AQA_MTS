using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using LogLevel = OpenQA.Selenium.LogLevel;

namespace SeleniumAdvanced.Core;

public class DriverFactory
{
    public static string? FileDownloadPath =
        Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Resources");
    public IWebDriver? GetChromeDriver()
    {
        var chromeOptions = new ChromeOptions();
       // chromeOptions.AddArguments("--incognito");
        chromeOptions.AddArguments("--disable-gpu");
        chromeOptions.AddArguments("--disable-extensions");
        //chromeOptions.AddArguments("--headless");

        chromeOptions.SetLoggingPreference(LogType.Browser, LogLevel.All);
        chromeOptions.SetLoggingPreference(LogType.Driver, LogLevel.All);

        chromeOptions.AddUserProfilePreference("download.default_directory", FileDownloadPath);

        new DriverManager().SetUpDriver(new ChromeConfig());
        return new ChromeDriver(chromeOptions);
    }
}