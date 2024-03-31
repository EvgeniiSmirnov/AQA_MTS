using OpenQA.Selenium;

namespace ChainOfInvocations.Pages.ProjectPages;

public class ProjectBasePage : BasePage
{
    private static readonly By NameInputBy = By.Id("name");

    public ProjectBasePage(IWebDriver driver) : base(driver) { }

    public ProjectBasePage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl) { }

    protected override string GetEndpoint()
    {
        throw new NotImplementedException();
    }
    public override bool IsPageOpened()
    {
        throw new NotImplementedException();
    }
}