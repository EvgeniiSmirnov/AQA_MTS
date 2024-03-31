using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace NativeSingleton.Core;

public class BrowserSingleton
{
    private static BrowserSingleton _instance;
    private static IWebDriver _driver;

    private BrowserSingleton()
    {
        // Инициализация драйвера здесь
        var chromeOptions = new ChromeOptions();
        chromeOptions.AddArguments("--incognito");
        chromeOptions.AddArguments("--disable-gpu");
        chromeOptions.AddArguments("--disable-extensions");
        //chromeOptions.AddArguments("--headless");

        chromeOptions.SetLoggingPreference(LogType.Browser, LogLevel.All);
        chromeOptions.SetLoggingPreference(LogType.Driver, LogLevel.All);

        new DriverManager().SetUpDriver(new ChromeConfig());
        _driver = new ChromeDriver(chromeOptions);
    }

    // Метод для получения единственного экземпляра класса
    public static BrowserSingleton GetInstance()
    {
        if (_instance == null)
        {
            _instance = new BrowserSingleton();
        }

        return _instance;
    }

    // Метод для получения экземпляра драйвера
    public IWebDriver GetDriver()
    {
        return _driver;
    }

    // Метод для закрытия драйвера
    public void CloseDriver()
    {
        _driver.Quit();
    }
}