using System.Collections.ObjectModel;
using System.Drawing;
using NativeSingleton.Core;
using NativeSingleton.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace NativeSingleton.Elements;

public class UIElement : IWebElement
{
    private IWebDriver _webDriver;
    private WaitsHelper _waitsHelper;
    private IWebElement _webElement;
    private Actions _actions;

    private UIElement()
    {
        _webDriver = BrowserSingleton.GetInstance().GetDriver();
        _waitsHelper = new WaitsHelper();
        _actions = new Actions(_webDriver);
    }

    public UIElement(By by) : this()
    {
        _webElement = _waitsHelper.WaitForExists(by);
    }

    public UIElement(IWebElement webElement) : this()
    {
        _webElement = webElement;
    }

    public IWebElement FindElement(By by)
    {
        return _webElement.FindElement(by);
    }

    public UIElement FindUIElement(By by)
    {
        return new UIElement(FindElement(by));
    }

    public ReadOnlyCollection<IWebElement> FindElements(By by)
    {
        return _webElement.FindElements(by);
    }

    public List<UIElement> FindUIElements(By by)
    {
        var result = new List<UIElement>();
        foreach (var webElement in FindElements(by))
        {
            result.Add(new UIElement(webElement));
        }

        return result;
    }

    public void Clear()
    {
        _webElement.Clear();
    }

    public void SendKeys(string text)
    {
        _webElement.SendKeys(text);
    }

    public void Submit()
    {
        _webElement.Submit();
    }

    public void Click()
    {
        try
        {
            _webElement.Click();
        }
        catch (ElementNotInteractableException)
        {
            try
            {
                _actions
                    .MoveToElement(_webElement)
                    .Click()
                    .Build()
                    .Perform();
            }
            catch (Exception)
            {
                MoveToElement();
                ((IJavaScriptExecutor)_webDriver).ExecuteScript("arguments[0].click();", _webElement);
            }
        }
    }

    public string GetAttribute(string attributeName)
    {
        return _webElement.GetAttribute(attributeName);
    }

    public string GetDomAttribute(string attributeName)
    {
        return _webElement.GetDomAttribute(attributeName);
    }

    public string GetDomProperty(string propertyName)
    {
        return _webElement.GetDomProperty(propertyName);
    }

    public string GetCssValue(string propertyName)
    {
        return _webElement.GetCssValue(propertyName);
    }

    public ISearchContext GetShadowRoot()
    {
        return _webElement.GetShadowRoot();
    }

    public void MoveToElement()
    {
        ((IJavaScriptExecutor)_webDriver).ExecuteScript("arguments[0].scrollIntoView(true);", _webElement);
    }

    public void Hover()
    {
        _actions.MoveToElement(_webElement).Build().Perform();
    }

    public string TagName => _webElement.TagName;

    public string Text
    {
        get
        {
            /*
            if (_webElement.Text != null || _webElement.Text.Equals(""))
            {
                if (GetAttribute("value").Equals(""))
                {
                    return GetAttribute("innerText");
                }

                return GetAttribute("value");
            }
            */

            return _webElement.Text;
        }
    }

    public bool Enabled => _webElement.Enabled;
    public bool Selected => _webElement.Selected;
    public Point Location => _webElement.Location;
    public Size Size => _webElement.Size;
    public bool Displayed => _webElement.Displayed;
}