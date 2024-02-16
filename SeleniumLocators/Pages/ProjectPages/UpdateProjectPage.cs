using OpenQA.Selenium;

namespace PageObject.Pages.ProjectPages;

public class UpdateProjectPage : ProjectBasePage
{
    private static string END_POINT = "index.php?/admin/projects/add";
    
    // Описание элементов
    private static readonly By SaveButtonBy = By.Id("name");

    
    public UpdateProjectPage(IWebDriver driver) : base(driver)
    {
    }

    public override bool IsPageOpened()
    {
        throw new NotImplementedException();
    }

    protected override string GetEndpoint()
    {
        throw new NotImplementedException();
    }

    // Атомарные Методы
    public IWebElement SaveButton => WaitsHelper.WaitForExists(SaveButtonBy);
}