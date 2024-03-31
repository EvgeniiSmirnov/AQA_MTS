using NUnit.Framework;
using ValueOfObjects.Pages;
using ValueOfObjects.Helpers.Configuration;

namespace ValueOfObjects.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessfulLoginTest()
    {
        DashboardPage dashboardPage = _navigationSteps
            .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        Assert.That(dashboardPage.IsPageOpened);
    }

    [Test]
    public void InvalidUsernameLoginTest()
    {
        // Проверка
        Assert.That(
            _navigationSteps
                .IncorrectLogin("ssdd", "123123")
                .GetErrorLabelText(),
            Is.EqualTo("Email/Login or Password is incorrect. Please try again."));
    }
}