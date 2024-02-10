using OpenQA.Selenium;
using SeleniumLocators.Helpers.Configuration;

namespace SeleniumLocators.Tests;

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

    [Test]
    public void basicLocatorsTest_2()
    {
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);

        // Find webElement by linkText
        Driver.FindElement(By.LinkText("Forgot your password?")).Click();

        // Find webElement by className
        Driver.FindElement(By.ClassName("forgot_passwordpage-request-cancel")).Click();

        // Find webElement by linkText
        Driver.FindElement(By.PartialLinkText("your password?")).Click();
    }
}