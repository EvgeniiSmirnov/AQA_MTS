using PageObjectSauceDemo.Helpers.Configuration;
using PageObjectSauceDemo.Pages;

namespace PageObjectSauceDemo.Tests;

class LoginTest : BaseTest
{
    [Test(Description = "Проверка успешного логина")]
    [TestCaseSource(typeof(TestData), nameof(TestData.AcessedUsenames))]
    public void UserLoginTest(string username)
    {
        
        InventoryPage inventoryPage = new LoginPage(Driver, true).Login(username, Configurator.AppSettings.Password);
        Assert.That(inventoryPage.IsPageOpened());
    }

    [Test(Description = "Проверка заблокированного username логина")]
    [TestCaseSource(typeof(TestData), nameof(TestData.BlockedUsenames))]
    public void BlockedUserLoginTest(string username)
    {
        LoginPage loginPage = new(Driver, true);
        loginPage.Login1(username, Configurator.AppSettings.Password);
        Assert.That(loginPage.ErrorContainer.Text.Trim(), Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
    }
    
    [Test(Description = "Проверка несуществующего username логина")]
    public void NotExistUserLoginTest()
    {
        LoginPage loginPage = new(Driver, true);
        loginPage.Login1("user", Configurator.AppSettings.Password);
        Assert.That(loginPage.ErrorContainer.Text.Trim(), Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
    }
}