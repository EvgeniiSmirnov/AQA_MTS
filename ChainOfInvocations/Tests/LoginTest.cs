using ChainOfInvocations.Pages;
using NUnit.Framework;
using ChainOfInvocations.Helpers.Configuration;

namespace ChainOfInvocations.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessfulLoginTest()
    {
        DashboardPage dashboardPage = NavigationSteps
            .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        Assert.That(dashboardPage.IsPageOpened);
    }

    [Test]
    public void InvalidUsernameLoginTest()
    {
        // Проверка
        Assert.That(
            NavigationSteps
                .IncorrectLogin("ssdd", "123123")
                .GetErrorLabelText(),
            Is.EqualTo("Email/Login or Password is incorrect. Please try again."));
    }
}