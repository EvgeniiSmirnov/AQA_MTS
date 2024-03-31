using System.Collections.ObjectModel;
using NativeSingleton.Core;
using NativeSingleton.Elements;
using NativeSingleton.Helpers.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace NativeSingleton.Helpers;

public class WaitsHelper(TimeSpan timeout)
{
    private readonly WebDriverWait _wait = new(BrowserSingleton.GetInstance().GetDriver(), timeout);

    public WaitsHelper() : this(TimeSpan.FromSeconds(Configurator.WaitsTimeout))
    {
    }

    public IWebElement WaitForVisibilityLocatedBy(By locator)
    {
        return _wait.Until(ExpectedConditions.ElementIsVisible(locator));
    }

    public ReadOnlyCollection<IWebElement> WaitForAllVisibleElementsLocatedBy(By locator)
    {
        return _wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(locator));
    }

    public ReadOnlyCollection<IWebElement> WaitForPresenceOfAllElementsLocatedBy(By locator)
    {
        return _wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(locator));
    }

    public IWebElement WaitForExists(By locator)
    {
        return _wait.Until(ExpectedConditions.ElementExists(locator));
    }

    public bool WaitForElementInvisible(By locator)
    {
        return _wait.Until(ExpectedConditions.InvisibilityOfElementLocated(locator));
    }

    public bool WaitForElementInvisible(IWebElement webElement)
    {
        try
        {
            // Проверка, видим ли элемент
            return _wait.Until(d => !webElement.Displayed);
        }
        catch (NoSuchElementException)
        {
            // Если элемент не найден, считаем его невидимым
            return true;
        }
        catch (StaleElementReferenceException)
        {
            // Если элемент устарел, считаем его невидимым
            return true;
        }
        catch (WebDriverTimeoutException)
        {
            throw new WebDriverTimeoutException("Элемент не стал невидимым в течение заданного времени");
        }
    }

    public bool WaitForVisibility(IWebElement element)
    {
        return _wait.Until(_ => element.Displayed);
    }

    public UIElement WaitChildElement(IWebElement webElement, By by)
    {
        return new UIElement(_wait.Until(_ => webElement.FindElement(by)));
    }

    public IWebElement FluentWaitForElement(By locator)
    {
        // Инициализация и параметризация FluentWait
        WebDriverWait fluentWait =
            new WebDriverWait(BrowserSingleton.GetInstance().GetDriver(), TimeSpan.FromSeconds(12))
            {
                PollingInterval = TimeSpan.FromMilliseconds(50)
            };

        fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));

        // Использование
        return fluentWait.Until(_ => BrowserSingleton.GetInstance().GetDriver().FindElement(locator));
    }
}