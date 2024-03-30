using OpenQA.Selenium;

namespace Wrappers.Pages.ProjectPages;

public class UpdateProjectPage : BasePage
{
    private static string END_POINT = "index.php?/admin/projects/add";

    // Описание элементов
    private static readonly By SaveButtonBy = By.Id("name");



    public UpdateProjectPage(IWebDriver driver) : base(driver)
    {
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public override bool IsPageOpened()
    {
        throw new NotImplementedException();
    }

    // Атомарные Методы
    public IWebElement SaveButton => WaitsHelper.WaitForExists(SaveButtonBy);
}