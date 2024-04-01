using OpenQA.Selenium;

namespace BuilderHomework.Elements;

public class TableCell(UIElement uiElement)
{
    private readonly UIElement _uiElement = uiElement;

    public UIElement GetLink() => _uiElement.FindUIElement(By.TagName("a"));
    public UIElement GetOverviewLink() => _uiElement.FindUIElement(By.CssSelector("span>a"));
    public string Text => _uiElement.Text;
}