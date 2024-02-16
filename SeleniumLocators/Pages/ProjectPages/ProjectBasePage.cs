using OpenQA.Selenium;

namespace PageObject.Pages.ProjectPages;

public abstract class ProjectBasePage : BasePage
{
    private static readonly By NameInputBy = By.Id("name");
    private BasePage _basePageImplementation;

    protected ProjectBasePage(IWebDriver driver, bool openPageByUrl = false) : base(driver, openPageByUrl)
    {
    }
    
    // Атомарные Методы
    public IWebElement NameInput => WaitsHelper.WaitForExists(NameInputBy);

}