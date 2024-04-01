using BuilderHomework.Elements;
using OpenQA.Selenium;

namespace BuilderHomework.Pages;

public class ProjectsPage : BasePage
{
    private static readonly string END_POINT = "index.php?/admin/projects/overview";

    private static readonly By TitleLabelBy = By.ClassName("page_title");
    private static readonly By AddProjectButtonBy = By.XPath("//*[contains(text(), 'Add Project')]");
    private static readonly By ProjectsTableBy = By.CssSelector("table.grid");

    public ProjectsPage(IWebDriver driver) : base(driver) { }
    public ProjectsPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl) { }

    protected override string GetEndpoint() => END_POINT;
    public override bool IsPageOpened() => TitleLabel.Text.Trim().Equals("Projects");

    public UIElement TitleLabel => new(Driver, TitleLabelBy);
    //public Button AddProjectButton => new(Driver, AddProjectButtonBy);
    public Table ProjectsTable => new(Driver, ProjectsTableBy);
}