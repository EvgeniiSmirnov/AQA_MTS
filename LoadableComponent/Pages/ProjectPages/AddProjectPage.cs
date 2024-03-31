using OpenQA.Selenium;

namespace LoadableComponent.Pages.ProjectPages;

public class AddProjectPage(IWebDriver? driver, bool openByURL = false) : BasePage(driver, openByURL)
{
    private const string END_POINT = "index.php?/admin/projects/add";

    // Описание элементов
    private static readonly By AddButtonBy = By.Id("name");

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    protected override bool EvaluateLoadedStatus()
    {
        throw new NotImplementedException();
    }

    // Атомарные Методы
    public IWebElement AddButton => WaitsHelper.WaitForExists(AddButtonBy);
}