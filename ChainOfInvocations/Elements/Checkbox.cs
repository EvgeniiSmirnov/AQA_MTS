using OpenQA.Selenium;

namespace ChainOfInvocations.Elements;

public class Checkbox(IWebDriver driver, By by)
{
    private readonly UIElement _UIElement = new(driver, by);

    private void Click() => _UIElement.Click();

    private void UseCheckbox(bool set)
    {
        if (IsSet() != set) Click();
    }

    public void SetCheckbox() => UseCheckbox(true);

    public void RemoveCheckbox() => UseCheckbox(false);

    public bool IsSet() => _UIElement.Selected;
}