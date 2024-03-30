using OpenQA.Selenium;
using Wrappers.Elements;

namespace Wrappers.Pages.ProjectPages;

public class AddProjectPage : ProjectBasePage
{
    private static string END_POINT = "index.php?/admin/projects/add";

    // Описание элементов
    private static readonly By AddButtonBy = By.Id("name");
    private static readonly By ShowAnnouncementCheckboxBy = By.Id("show_announcement");

    public AddProjectPage(IWebDriver driver) : base(driver)
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

    public Checkbox ShowAnnouncementCheckbox => new(Driver, ShowAnnouncementCheckboxBy);
}