using OpenQA.Selenium;
using Wrappers.Elements;

namespace Wrappers.Pages.ProjectPages;

public class AddTestCasePage : BasePage
{
    private static readonly string END_POINT = "index.php?/cases/add/1";

    private static readonly By SectionDropDownBy = By.Id("section_id_chzn");
    private static readonly By TemplateDropDownBy = By.Id("template_id_chzn");

    public AddTestCasePage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl) { }

    public DropDownMenu SectionDropDown => new DropDownMenu(Driver, SectionDropDownBy);

    public DropDownMenu TemplateDropDown => new DropDownMenu(Driver, TemplateDropDownBy);

    protected override string GetEndpoint() => END_POINT;

    public override bool IsPageOpened() => throw new NotImplementedException();
}