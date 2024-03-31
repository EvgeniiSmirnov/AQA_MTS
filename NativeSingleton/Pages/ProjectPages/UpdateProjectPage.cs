using OpenQA.Selenium;

namespace NativeSingleton.Pages.ProjectPages;

public class UpdateProjectPage(bool openByURL = false) : ProjectBasePage(openByURL)
{
    private const string END_POINT = "index.php?/admin/projects/add";

    // Описание элементов
    private static readonly By SaveButtonBy = By.Id("name");

    protected override bool EvaluateLoadedStatus()
    {
        return WaitsHelper.WaitForExists(SaveButtonBy).Displayed;
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    // Атомарные Методы
    public IWebElement SaveButton => WaitsHelper.WaitForExists(SaveButtonBy);
}