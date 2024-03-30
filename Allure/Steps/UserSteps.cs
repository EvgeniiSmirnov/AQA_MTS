using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using Wrappers.Helpers.Configuration;
using Wrappers.Pages;

namespace Wrappers.Steps;

public class UserSteps : BaseSteps
{
    private LoginPage _loginPage;

    public UserSteps(IWebDriver driver) : base(driver)
    {
        _loginPage = new LoginPage(Driver);
    }

    // Комплексные
    public DashboardPage SuccessfulLogin()
    {
        _loginPage.EmailInput.SendKeys(Configurator.AppSettings.Username);
        _loginPage.PswInput.SendKeys(Configurator.AppSettings.Password);
        _loginPage.ClickLoginInButton();

        return new DashboardPage(Driver);
    }

    public DashboardPage SuccessfulLogin(string username, string password)
    {
        _loginPage.EmailInput.SendKeys(username);
        _loginPage.PswInput.SendKeys(password);
        _loginPage.ClickLoginInButton();

        return new DashboardPage(Driver);
    }

    public LoginPage IncorrectLogin(string username, string password)
    {
        _loginPage.EmailInput.SendKeys(username);
        _loginPage.PswInput.SendKeys(password);
        _loginPage.LoginInButton.Click();

        return _loginPage;
    }
}