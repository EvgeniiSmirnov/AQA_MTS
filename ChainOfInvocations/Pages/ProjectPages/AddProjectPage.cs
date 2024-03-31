using OpenQA.Selenium;
using ChainOfInvocations.Elements;

namespace ChainOfInvocations.Pages.ProjectPages;

public class AddProjectPage : ProjectBasePage
{
    private static string END_POINT = "index.php?/admin/projects/add";

    private static readonly By _nameInputBy = By.Id("name");
    private static readonly By _announcementInputBy = By.Id("announcement_display");
    private static readonly By _showAnnouncementCheckboxBy = By.Id("show_announcement");
    private static readonly By _projectTypeRadioBy = By.Name("suite_mode");
    private static readonly By _caseApprovalsCheckboxBy = By.Id("case_statuses_enabled");
    private static readonly By _addButtonBy = By.Id("accept");

    public AddProjectPage(IWebDriver driver) : base(driver) { }
    public AddProjectPage(IWebDriver driver, bool openByUrl) : base(driver, openByUrl) { }

    protected override string GetEndpoint() => END_POINT;
    public override bool IsPageOpened() => throw new NotImplementedException();

    public UIElement NameInput => new(Driver, _nameInputBy);
    public UIElement AnnouncementInput => new(Driver, _announcementInputBy);
    public Checkbox ShowAnnouncementCheckbox => new(Driver, _showAnnouncementCheckboxBy);
    public RadioButton ProjectTypeRadio => new(Driver, _projectTypeRadioBy);
    public Checkbox CaseApprovalsCheckbox => new(Driver, _caseApprovalsCheckboxBy);
    public Button AddButton => new(Driver, _addButtonBy);

    public AddProjectPage InputNameValue(string value)
    {
        NameInput.SendKeys(value);
        return this;
    }

    public AddProjectPage InputAnnouncementValue(string value)
    {
        AnnouncementInput.SendKeys(value);
        return this;
    }

    public AddProjectPage CheckShowAnnouncementCheckbox()
    {
        ShowAnnouncementCheckbox.SetCheckbox();
        return this;
    }

    public AddProjectPage ChooseProjectType(string value)
    {
        ProjectTypeRadio.SelectByText(value);
        return this;
    }

    public AddProjectPage ChooseProjectType(int index)
    {
        ProjectTypeRadio.SelectByIndex(index);
        return this;
    }

    public AddProjectPage CheckCaseApprovalsCheckbox()
    {
        CaseApprovalsCheckbox.SetCheckbox();
        return this;
    }

    public ProjectsPage ClickAddButton()
    {
        AddButton.Click();
        return new ProjectsPage(Driver);
    }
}