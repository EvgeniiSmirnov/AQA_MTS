using PageObjectSimpleSauceDemo.Helpers.Configuration;
using PageObjectSimpleSauceDemo.Pages;

namespace PageObjectSimpleSauceDemo.Tests;

class LoginTest : BaseTest
{
    [Test(Description = "Проверка успешного логина")]
    [TestCaseSource(typeof(TestData), nameof(TestData.AcessedUsenames))]
    public void UserLoginTest(string username)
    {
        InventoryPage inventoryPage = new LoginPage(Driver, true)
            .Login(username, Configurator.AppSettings.Password);
        
        // проверяем, что после логина открылась ожидаемая страница
        Assert.That(inventoryPage.IsPageOpened());
    }

    [Test(Description = "Проверка заблокированного username логина")]
    [TestCaseSource(typeof(TestData), nameof(TestData.BlockedUsenames))]
    public void BlockedUserLoginTest(string username)
    {
        LoginPage loginPage = new(Driver, true);
        loginPage.LoginAttempt(username, Configurator.AppSettings.Password);

        // проверяем, что сообщение содержит ожидаемый текст
        Assert.That(loginPage.ErrorContainer.Text.Trim(),
            Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
    }

    [Test(Description = "Проверка несуществующего username логина")]
    public void NotExistUserLoginTest()
    {
        LoginPage loginPage = new(Driver, true);
        loginPage.LoginAttempt("user", Configurator.AppSettings.Password);

        // проверяем, что сообщение содержит ожидаемый текст
        Assert.That(loginPage.ErrorContainer.Text.Trim(),
            Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
    }
}