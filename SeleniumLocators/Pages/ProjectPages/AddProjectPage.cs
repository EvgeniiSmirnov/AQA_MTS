using OpenQA.Selenium;

namespace PageObject.Pages.ProjectPages;

public class AddProjectPage : ProjectBasePage
{
    private static string END_POINT = "index.php?/admin/projects/add";
    
    // Описание элементов
    private static readonly By AddButtonBy = By.Id("name");
    
    public AddProjectPage(IWebDriver driver) : base(driver)
    {
    }

    public AddProjectPage(IWebDriver driver, bool openByUrl) : base(driver, openByUrl)
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
    public IWebElement AddButton => Driver.FindElement(AddButtonBy); 
}