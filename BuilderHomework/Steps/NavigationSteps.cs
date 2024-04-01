using BuilderHomework.Models;
using BuilderHomework.Pages;
using OpenQA.Selenium;

namespace BuilderHomework.Steps;

public class NavigationSteps(IWebDriver driver) : BaseSteps(driver)
{
    public LoginPage NavigateToLoginPage() => new LoginPage(Driver, true);
    public DashboardPage NavigateToDashboardPage() => new DashboardPage(Driver, true);

    public DashboardPage SuccessfulLogin(User user) => Login<DashboardPage>(user);
    public LoginPage IncorrectLogin(User user) => Login<LoginPage>(user);

    private T Login<T>(User user) where T : BasePage
    {
        LoginPage = new LoginPage(Driver);
        LoginPage.EmailInput.SendKeys(user.Email);
        LoginPage.PswInput.SendKeys(user.Password);
        LoginPage.LoginInButton.Click();

        return (T)Activator.CreateInstance(typeof(T), Driver, false);
    }
}