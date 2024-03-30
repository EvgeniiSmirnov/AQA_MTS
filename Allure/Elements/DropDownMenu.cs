using OpenQA.Selenium;

namespace Wrappers.Elements;

public class DropDownMenu
{
    private readonly UIElement _uiElement;
    private readonly List<UIElement> _uiElementList;
    private readonly List<string> _texts;

    public DropDownMenu(IWebDriver driver, By by)
    {
        _uiElement = new UIElement(driver, by);
        _uiElementList = new List<UIElement>();
        _texts = new List<string>();

        _uiElement.Click();
        foreach (var webElement in _uiElement.FindUIElements(By.XPath("descendant::li")))
        {
            _uiElementList.Add(webElement);
            _texts.Add(webElement.Text.Trim());
        }
    }

    public void SelectByText(string text)
    {
        _uiElementList[_texts.IndexOf(text)].Click();
    }

    public void SelectByIndex(int index)
    {
        if (index < _uiElementList.Count)
        {
            _uiElementList[index].Click();
        }
        else
        {
            throw new AssertionException("Превышен индекс");
        }
    }
}