using OpenQA.Selenium;
using SauceDemo.Helpers.Configuration;

namespace SauceDemo.Tests;

public class SauceDemoTest : BaseTest
{
    [Test]
    public void LocatorsBaseTest()
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
    public void LocatorsXPathTest()
    {
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);

        Assert.Multiple(() =>
        {
            Assert.That(Driver.FindElement(By.XPath("//input[@id='user-name']")).Displayed);
            Assert.That(Driver.FindElement(By.XPath("//*[text()='Accepted usernames are:']")).Displayed);
            Assert.That(Driver.FindElement(By.XPath("//input[contains(@name,'name')]")).Displayed);
            Assert.That(Driver.FindElement(By.XPath("//h4[contains(text(),'Accepted')]")).Displayed);
            Assert.That(Driver.FindElement(By.XPath("//*[text()='standard_user']//ancestor::div")).Displayed);
            Assert.That(Driver.FindElement(By.XPath("//*[@class='login_credentials_wrap']//descendant::h4")).Displayed);
            Assert.That(Driver.FindElement(By.XPath("//*[@class='error-message-container']/following::input")).Displayed);
            Assert.That(Driver.FindElement(By.XPath("//*[@class='form_group']//parent::form")).Displayed);
            Assert.That(Driver.FindElement(By.XPath("//*[@class='login_credentials']//preceding::form")).Displayed);
            Assert.That(Driver.FindElement(By.XPath("//*[@type='password' and @name='password']")).Displayed);
        });
    }

    [Test]
    public void LocatorsSCCTest()
    {
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);

        Assert.Multiple(() =>
        {
            Assert.That(Driver.FindElement(By.CssSelector(".submit-button")).Displayed);
            Assert.That(Driver.FindElement(By.CssSelector(".submit-button.btn_action")).Displayed);
            Assert.That(Driver.FindElement(By.CssSelector(".login_credentials_wrap .login_password")).Displayed);
            Assert.That(Driver.FindElement(By.CssSelector("#login_button_container")).Displayed);
            Assert.That(Driver.FindElement(By.CssSelector("h4")).Displayed);
            Assert.That(Driver.FindElement(By.CssSelector("input.submit-button")).Displayed);

            Assert.That(Driver.FindElement(By.CssSelector("[placeholder='Password']")).Displayed);
            Assert.That(Driver.FindElement(By.CssSelector("[placeholder~='Username']")).Displayed);
            Assert.That(Driver.FindElement(By.CssSelector("[class|='login-box']")).Displayed);
            Assert.That(Driver.FindElement(By.CssSelector("[data-test^='l']")).Displayed);
            Assert.That(Driver.FindElement(By.CssSelector("[data-test$='n']")).Displayed);
            Assert.That(Driver.FindElement(By.CssSelector("[data-test*='-']")).Displayed);
        });
    }
}