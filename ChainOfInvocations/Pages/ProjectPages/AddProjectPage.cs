using OpenQA.Selenium;
using ChainOfInvocations.Elements;

namespace ChainOfInvocations.Pages.ProjectPages;

public class AddProjectPage : ProjectBasePage
{
    private static string END_POINT = "index.php?/admin/projects/add";

    private static readonly By ProjectNameBy = By.Id("name");
    private static readonly By AnnouncementBy = By.Id("announcement_display");
    private static readonly By AnnouncementCheckboxBy = By.Id("show_announcement");
    private static readonly By ProjectTypeRadioButton = By.Name("suite_mode");
    private static readonly By TestApprovalsCheckboxBy = By.Id("case_statuses_enabled");
    private static readonly By AddButtonBy = By.Id("accept");

    public AddProjectPage(IWebDriver driver) : base(driver) { }
    public AddProjectPage(IWebDriver driver, bool openByUrl) : base(driver, openByUrl) { }

    protected override string GetEndpoint() => END_POINT;
    public override bool IsPageOpened() => throw new NotImplementedException();

    public UIElement NameInput => new(Driver, ProjectNameBy);

    public UIElement AnnouncementInput => new(Driver, AnnouncementBy);

    public Checkbox ShowAnnouncementCheckbox => new(Driver, AnnouncementCheckboxBy);

    public RadioButton ProjectTypeRadio => new(Driver, ProjectTypeRadioButton);

    public Checkbox CaseApprovalsCheckbox => new(Driver, TestApprovalsCheckboxBy);

    public Button AddButton => new(Driver, AddButtonBy);

    public AddProjectPage InputProjectName(string value)
    {
        NameInput.SendKeys(value);
        return this;
    }

    public AddProjectPage InputAnnouncement(string value)
    {
        AnnouncementInput.SendKeys(value);
        return this;
    }

    public AddProjectPage SetCheckboxShowAnnouncement(bool value)
    {
        ShowAnnouncementCheckbox.UseCheckbox(value);
        return this;
    }

    public AddProjectPage ChooseProjectType(string value)
    {
        ProjectTypeRadio.SelectByText(value);
        return this;
    }

    public AddProjectPage SetProjectType(int index)
    {
        ProjectTypeRadio.SelectByIndex(index);
        return this;
    }

    public AddProjectPage SetCheckboxTestCaseApprovals(bool value)
    {
        CaseApprovalsCheckbox.UseCheckbox(value);
        return this;
    }

    public ProjectsPage MainAddButtonClick()
    {
        AddButton.Click();
        return new ProjectsPage(Driver);
    }
}