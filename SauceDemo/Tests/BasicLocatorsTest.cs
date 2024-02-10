using OpenQA.Selenium;
using SauceDemo.Helpers.Configuration;

namespace SauceDemo.Tests;

public class BasicLocatorsTest : BaseTest
{
    [Test]
    public void basicLocatorsTest_1()
    {
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);

        // Find webElement by ID
        Driver.FindElement(By.Id("name")).SendKeys(Configurator.AppSettings.Username);

        // Find webElement by Name
        Driver.FindElement(By.Name("password")).SendKeys(Configurator.AppSettings.Password);

        // Find webElement by TagName
        Driver.FindElement(By.TagName("button")).Click();
        
        Console.WriteLine($"{this} Finished...");
    }
}