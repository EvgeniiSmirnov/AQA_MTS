using PageObjectSauceDemo.Helpers.Configuration;
using PageObjectSauceDemo.Pages;

namespace PageObjectSauceDemo.Tests;

class LoginTest : BaseTest
{
    [Test(Description = "Проверка успешного логина")]
    [TestCaseSource(typeof(TestData), nameof(TestData.AcessedUsenames1))]
    public void UserLoginTest(string username)
    {
        
        InventoryPage inventoryPage = new LoginPage(Driver, true).Login(username, Configurator.AppSettings.Password);
        Assert.That(inventoryPage.IsPageOpened());
    }

    [Test(Description = "Проверка заблокированного юзер логина")]
    [TestCaseSource(typeof(TestData), nameof(TestData.BlockedUsenames))]
    public void UserLoginTest1(string username)
    {
        LoginPage loginPage = new LoginPage(Driver, true);
        loginPage.Login1(username, Configurator.AppSettings.Password);
        Assert.That(loginPage.ErrorContainer.Text.Trim(), Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
    }
}
