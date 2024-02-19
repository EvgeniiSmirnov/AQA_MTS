using Allure.Helpers.Configuration;
using Allure.Net.Commons;
using Allure.Steps;
using NUnit.Allure.Attributes;

namespace Allure.Tests;

class LoginTest : BaseTest
{
    [Test(Description = "Проверка успешного логина")]
    [TestCaseSource(typeof(TestData), nameof(TestData.AcessedUsenames))]
    [AllureSeverity(SeverityLevel.normal)]
    public void UserLoginTest(string username)
    {
        NavigationSteps.NavigateToLoginPage();
        NavigationSteps.Login(username, Configurator.AppSettings.Password);

        // проверяем, что 
        AllureApi.Step("после логина открылась ожидаемая страница");
        Assert.That(NavigationSteps.InventoryPage.IsPageOpened());
    }

    [Test(Description = "Проверка заблокированного username логина")]
    [TestCaseSource(typeof(TestData), nameof(TestData.BlockedUsenames))]
    [AllureSeverity(SeverityLevel.normal)]
    public void BlockedUserLoginTest(string username)
    {
        NavigationSteps.NavigateToLoginPage();
        NavigationSteps.Login(username, Configurator.AppSettings.Password);

        // проверяем, что 
        AllureApi.Step("сообщение содержит ожидаемый текст");
        Assert.That(NavigationSteps.LoginPage.ErrorContainer.Text.Trim(),
            Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
        TakeScreenshot("сообщение об ошибке");
    }

    [Test(Description = "Проверка несуществующего username логина")]
    [AllureSeverity(SeverityLevel.normal)]
    public void NotExistUserLoginTest()
    {
        NavigationSteps.NavigateToLoginPage();
        NavigationSteps.Login("user", Configurator.AppSettings.Password);

        // проверяем, что сообщение содержит ожидаемый текст
        AllureApi.Step("сообщение содержит ожидаемый текст");
        Assert.That(NavigationSteps.LoginPage.ErrorContainer.Text.Trim(),
            Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
        TakeScreenshot("сообщение об ошибке");
    }
}