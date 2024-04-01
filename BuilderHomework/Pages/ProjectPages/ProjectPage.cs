using BuilderHomework.Elements;
using OpenQA.Selenium;

namespace BuilderHomework.Pages.ProjectPages;

public class ProjectPage(IWebDriver driver) : ProjectBasePage(driver)
{
    private static readonly By _addMilestoneButtonBy = By.Id("navigation-overview-addmilestones");

    protected override string GetEndpoint() => throw new NotImplementedException();
    public override bool IsPageOpened() => throw new NotImplementedException();

    public Button AddMilestoneButton => new(Driver, _addMilestoneButtonBy);

    public AddMilestonePage AddMilestoneButtonClick()
    {
        AddMilestoneButton.Click();
        return new AddMilestonePage(Driver);
    }
}