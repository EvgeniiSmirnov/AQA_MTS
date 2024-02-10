using OpenQA.Selenium;

namespace SeleniumAdvanced.Tests;

public class WaitsTest : BaseTest
{
    [Test]
    public void PresenceOfElementTest() {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/dynamic_loading/1");

        IWebElement button = Driver.FindElement(By.TagName("button"));
        button.Click();
        Assert.That(button.Displayed);

        IWebElement loading = Driver.FindElement(By.Id("loading"));
        Assert.That(loading.Displayed);
        Assert.That(!loading.Displayed);

        Assert.That(Driver.FindElement(By.Id("finish")).Displayed);
    }

    [Test]
    public void PresenceOfElementTest1() {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/dynamic_loading/1");

        IWebElement button = WaitsHelper.WaitForVisibilityLocatedBy(By.TagName("button"));
        button.Click();
        Assert.That(WaitsHelper.WaitForElementInvisible(button));

        IWebElement loading = WaitsHelper.WaitForVisibilityLocatedBy(By.Id("loading"));
        Assert.That(loading.Displayed);
        Assert.That(WaitsHelper.WaitForElementInvisible(loading));

        Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("finish")).Displayed);
    }
}