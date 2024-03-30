using Wrappers.Pages.ProjectPages;
using Wrappers.Steps;

namespace Wrappers.Tests;

public class CheckboxTest : BaseTest
{
    [Test]
    public void SetCheckboxTest()
    {
        UserSteps
            .SuccessfulLogin()
            .AddProjectButton.Click();

        AddProjectPage addProjectPage = new(Driver);

        addProjectPage.ShowAnnouncementCheckbox.SetCheckbox();
        Assert.That(addProjectPage.ShowAnnouncementCheckbox.IsSet);

        addProjectPage.ShowAnnouncementCheckbox.RemoveCheckbox();
        Assert.That(addProjectPage.ShowAnnouncementCheckbox.IsSet, Is.False);
    }
}