using OpenQA.Selenium;

namespace SeleniumAdvanced.Tests;

public class AlertTests : BaseTest
{
    [Test]
    public void InfoAlertTest()
    {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/javascript_alerts");

        Driver.FindElement(By.XPath("//button[. = 'Click for JS Alert']")).Click();

        IAlert alert = Driver.SwitchTo().Alert();

        Assert.That(alert.Text, Is.EqualTo("I am a JS Alert"));

        alert.Accept();
    }

    [Test]
    public void ConfirmAlertTest()
    {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/javascript_alerts");

        Driver.FindElement(By.XPath("//button[. = 'Click for JS Confirm']")).Click();

        IAlert alert = Driver.SwitchTo().Alert();

        Assert.That(alert.Text, Is.EqualTo("I am a JS Confirm"));

        alert.Dismiss();

        Thread.Sleep(3000);
    }

    [Test]
    public void PromptAlertTest() 
    {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/javascript_alerts");
        
        Driver.FindElement(By.XPath("//button[. = 'Click for JS Prompt']")).Click();
        
        IAlert alert = Driver.SwitchTo().Alert();
        
        Assert.That(alert.Text, Is.EqualTo("I am a JS prompt"));
        
        alert.SendKeys("Everything is OK!");
        alert.Accept();
        
        Thread.Sleep(5000);
    }
}