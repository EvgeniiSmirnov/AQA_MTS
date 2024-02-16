using OpenQA.Selenium;

namespace PageObject.Tests;

public class WindowsTest : BaseTest
{
    [Test]
    public void NewTabTest()
    {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/windows");

        String originalWindow = Driver.CurrentWindowHandle;
        
        Driver.FindElement(By.LinkText("Click Here")).Click();

        var windowHandlesSet = Driver.WindowHandles;

        Driver.SwitchTo().Window(windowHandlesSet[1]);

        Thread.Sleep(3000);
        Assert.That(Driver.FindElement(By.TagName("h3")).Text, Is.EqualTo("New Window"));

        Driver.Close();
        
        Thread.Sleep(3000);
        Driver.SwitchTo().Window(originalWindow);
        Assert.That(Driver.FindElement(By.LinkText("Click Here")).Displayed);
    }
}