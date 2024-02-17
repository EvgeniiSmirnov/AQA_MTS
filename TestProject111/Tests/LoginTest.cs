using TestProject111.Helpers.Configuration;
using TestProject111.Pages;
using TestProject111.Steps;

namespace TestProject111.Tests;

public class LoginTest : BaseTest
{
    [TestCase("standard_user")]
    [TestCase("problem_user")]
    [TestCase("performance_glitch_user")]
    [TestCase("error_user")]
    [TestCase("visual_user")]
    [Description("Проверка успешного входа")]
    public void SuccessLoginTest(string login)
    {


        LoginSteps.NavigateToLoginPage();
        LoginSteps.SuccessfulLogin(login, Configurator.AppSettings.Password);

        Assert.That(LoginSteps.CatalogPage.IsPageOpened());
    }




}