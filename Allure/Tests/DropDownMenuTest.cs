using Wrappers.Pages.ProjectPages;
using Wrappers.Steps;

namespace Wrappers.Tests;

public class DropDownMenuTest : BaseTest
{
    [Test]
    public void DropDownTest()
    {
        UserSteps.SuccessfulLogin();

        AddTestCasePage addTestCasePage = new(Driver, true);

        addTestCasePage.SectionDropDown.SelectByIndex(2);
        addTestCasePage.TemplateDropDown.SelectByText("Test Case (Steps)");
    }
}