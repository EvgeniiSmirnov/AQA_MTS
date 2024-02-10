using AngleSharp.Dom;
using OpenQA.Selenium;
using SauceDemo.Helpers.Configuration;
using System.Xml.Linq;

namespace SauceDemo.Tests;

public class SauceDemoTest : BaseTest
{
    [Test]
    public void LocatorsBaseCheck()
    {
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);

        Assert.Multiple(() =>
        {
            // id name classname tagname 
            Assert.That(Driver.FindElement(By.ClassName("login_logo")).Displayed);
            Assert.That(Driver.FindElement(By.Id("user-name")).Displayed);
            Assert.That(Driver.FindElement(By.Name("password")).Displayed);
            Assert.That(Driver.FindElements(By.TagName("h4")).Count == 2 );

            // linktext partiallinktext
            Driver.FindElement(By.Id("user-name")).SendKeys(Configurator.AppSettings.Username);
            Driver.FindElement(By.Id("password")).SendKeys(Configurator.AppSettings.Password);
            Driver.FindElement(By.Id("login-button")).Click();

            Assert.That(Driver.FindElement(By.LinkText("Sauce Labs Backpack")).Displayed);
            Assert.That(Driver.FindElement(By.PartialLinkText("Bike")).Displayed);
        });
    }

    [Test]
    public void LocatorsCSSCheck()
    {
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);

        Assert.Multiple(() =>
        {

        });

        Thread.Sleep(5000);

        Console.WriteLine($"{this} Finished...");
    }
}