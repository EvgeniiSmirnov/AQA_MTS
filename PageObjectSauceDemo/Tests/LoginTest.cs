using PageObjectStepsSauceDemo.Helpers.Configuration;
using PageObjectStepsSauceDemo.Steps;

namespace PageObjectStepsSauceDemo.Tests;

class LoginTest : BaseTest
{
    [Test(Description = "Проверка успешного логина")]
    [TestCaseSource(typeof(TestData), nameof(TestData.AcessedUsenames))]
    public void UserLoginTest(string username)
    {
        NavigationSteps.NavigateToLoginPage();
        NavigationSteps.Login(username, Configurator.AppSettings.Password);
        
        // проверяем, что после логина открылась ожидаемая страница
        Assert.That(NavigationSteps.InventoryPage.IsPageOpened());
    }

    [Test(Description = "Проверка заблокированного username логина")]
    [TestCaseSource(typeof(TestData), nameof(TestData.BlockedUsenames))]
    public void BlockedUserLoginTest(string username)
    {
        NavigationSteps.NavigateToLoginPage();
        NavigationSteps.Login(username, Configurator.AppSettings.Password);

        // проверяем, что сообщение содержит ожидаемый текст
        Assert.That(NavigationSteps.LoginPage.ErrorContainer.Text.Trim(),
            Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
    }

    [Test(Description = "Проверка несуществующего username логина")]
    public void NotExistUserLoginTest()
    {
        NavigationSteps.NavigateToLoginPage();
        NavigationSteps.Login("user", Configurator.AppSettings.Password);

        // проверяем, что сообщение содержит ожидаемый текст
        Assert.That(NavigationSteps.LoginPage.ErrorContainer.Text.Trim(),
            Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
    }
}