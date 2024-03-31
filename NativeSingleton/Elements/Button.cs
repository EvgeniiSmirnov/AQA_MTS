using OpenQA.Selenium;

namespace NativeSingleton.Elements;

public class Button
{
    private UIElement _uiElement;

    public Button(By by)
    {
        _uiElement = new UIElement(by);
    }

    public Button(IWebElement webElement)
    {
        _uiElement = new UIElement(webElement);
    }

    public void Click()
    {
        _uiElement.Click();
    }

    public void Submit()
    {
        _uiElement.Submit();
    }

    public string Text => _uiElement.Text;
    public bool Displayed => _uiElement.Displayed;
}