using OpenQA.Selenium;
using Wrappers.Elements;
using Wrappers.Helpers.Configuration;
using Wrappers.Pages.ProjectPages;
using Wrappers.Steps;

namespace Wrappers.Tests;

public class RadioButtonTest : BaseTest
{
    [Test]
    public void AddProjectCorrectTest()
    {
       UserSteps
            .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password)
            .AddProjectButton.Click();

        AddProjectPage addProjectPage = new AddProjectPage(Driver);
        addProjectPage.ProjectTypeRadioButton.SelectByIndex(1);
        addProjectPage.ProjectTypeRadioButton.SelectByValue("3");
        addProjectPage.ProjectTypeRadioButton.SelectByText("Use a single repository for all cases (recommended)");
    }

    [Test]
    public void TmpTest()
    {
        UserSteps
            .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        Driver.Navigate().GoToUrl("https://smirnov707070.testrail.io/index.php?/admin/site_settings#");

        Button tmpElement1 = new(Driver, By.Id("navigation-sitesettings-backup"));
        tmpElement1.Click();
        RadioButton tmpElement = new(Driver, By.Name("restore_backup"));

        tmpElement.SelectByIndex(0);
    }
}