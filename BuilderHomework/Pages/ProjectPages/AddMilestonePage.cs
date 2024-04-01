using BuilderHomework.Elements;
using OpenQA.Selenium;

namespace BuilderHomework.Pages.ProjectPages;

public class AddMilestonePage : ProjectBasePage
{
    private static readonly By _projectNameInputBy = By.Id("name");
    private static readonly By _referenceInputBy = By.Id("reference");
    private static readonly By _parentDropDownBy = By.Id("show_announcement");
    private static readonly By _descriptionInputBy = By.Id("description_display");
    private static readonly By _startDateBy = By.Id("start_on");
    private static readonly By _endDateBy = By.Id("is_completed");
    private static readonly By _CheckboxMilestoneCompletedBy = By.Id("due_on");
    private static readonly By _addButtonBy = By.Id("accept");

    public AddMilestonePage(IWebDriver driver) : base(driver) { }

    protected override string GetEndpoint() => throw new NotImplementedException();
    public override bool IsPageOpened() => throw new NotImplementedException();

    public UIElement NameInput => new(Driver, _projectNameInputBy);
    public UIElement ReferenceInput => new(Driver, _referenceInputBy);
    public DropDownMenu ParentDropDown => new(Driver, _parentDropDownBy);
    public UIElement DescriptionInput => new(Driver, _descriptionInputBy);
    public Calendar StartDate => new(Driver, _startDateBy);
    public Calendar EndDate => new(Driver, _endDateBy);
    public Checkbox IsCompleted => new(Driver, _CheckboxMilestoneCompletedBy);
    public Button AddButton => new(Driver, _addButtonBy);

    public AddMilestonePage InputMilestoneName(string name)
    {
        NameInput.SendKeys(name);
        return this;
    }

    public AddMilestonePage InputReference(string reference)
    {
        ReferenceInput.SendKeys(reference);
        return this;
    }

    public AddMilestonePage AddParent(int index)
    {
        ParentDropDown.SelectByIndex(index);
        return this;
    }

    public AddMilestonePage InputDescription(string description)
    {
        DescriptionInput.SendKeys(description);
        return this;
    }

    public AddMilestonePage SetStartDate(int day)
    {
        StartDate.SelectDay(day);
        return this;
    }

    public AddMilestonePage SetEndDate(int day)
    {
        EndDate.SelectDay(day);
        return this;
    }

    public AddMilestonePage SetCheckbomMilestoneCompleted(bool value)
    {
        IsCompleted.UseCheckbox(value);
        return this;
    }

    public ProjectMilestonesPage AddButtonClick()
    {
        AddButton.Click();
        return new ProjectMilestonesPage(Driver);
    }
}