using NUnit.Framework;
using LoadableComponent.Pages;
using LoadableComponent.Helpers.Configuration;

namespace LoadableComponent.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessfulLoginTest()
    {
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.Load();

        loginPage.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        // принудительно переоходим на другую страницу
        //Driver.Navigate().GoToUrl("https://smirnov707070.testrail.io//index.php?/mysettings");
        // нас вернёт на нужную страницу метод EvaluateLoadedStatus
        //DashboardPage dashboardPage = new DashboardPage(Driver, true);

        DashboardPage dashboardPage = new DashboardPage(Driver);
        dashboardPage.SidebarProjectsAddButton.Click();
    }
}