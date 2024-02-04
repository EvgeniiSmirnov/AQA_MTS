using OpenQA.Selenium;
using SeleniumBasic;

[TestFixture]
public class WebDriverTest
{
    [Test]
    public void SimpleDriverTest()
    {
        IWebDriver webDriver = new SimpleDriver().Driver;
        //webDriver.Navigate().GoToUrl("https://clinic-cvetkov.ru/company/kalkulyator-imt");
        webDriver.Navigate().GoToUrl("https://google.com");
        IWebElement height = webDriver.FindElement(By.Id("APjFqb"));
        
        webDriver.Quit();
    }

    [Test]
    public void AdvancedDriverTest()
    {
        //IWebDriver webDriver = new AdvancedDriver().GetChromeDriver();
        //webDriver.Navigate().GoToUrl("http://onliner.by");
        //webDriver.Quit();
    }

    [Test]
    public void FactoryDriverTest()
    {
        IWebDriver webDriver = new Browser().Driver!;
        webDriver.Navigate().GoToUrl("http://onliner.by");
        webDriver.Quit();
    }
}