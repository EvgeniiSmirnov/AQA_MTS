using BuilderHomework.Steps;
using NUnit.Framework;
using BuilderHomework.Pages;

namespace BuilderHomework.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessLoginTest()
    {
        DashboardPage dashboardPage = NavigationSteps.SuccessfulLogin(Admin);

        Assert.That(dashboardPage.IsPageOpened);
    }
}