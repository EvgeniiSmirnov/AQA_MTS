using OpenQA.Selenium;

namespace BuilderHomework.Elements
{
    public class Calendar(IWebDriver webDriver, By locator)
    {
        private readonly UIElement _uiElement = new UIElement(webDriver, locator);

        public void SelectDay(int value)
        {
            _uiElement.Click();
            _uiElement.FindUIElement(By.XPath($"//a[text()='{value}']")).Click();
        }
    }
}