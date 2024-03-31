using NativeSingleton.Helpers.Configuration;
using NativeSingleton.Models;
using NativeSingleton.Pages;
using NativeSingleton.Pages.ProjectPages;

namespace NativeSingleton.Steps;

public class NavigationSteps : BaseSteps
{
    public LoginPage NavigateToLoginPage()
    {
        return new LoginPage();
    }

    public DashboardPage NavigateToDashboardPage()
    {
        return new DashboardPage();
    }

    public AddProjectPage NavigateToAddProjectPage()
    {
        return new AddProjectPage();
    }

    public DashboardPage SuccessfulLogin(User user)
    {
        return Login<DashboardPage>(user);
    }

    public DashboardPage SuccessfulLoginByAdmin()
    {
        var Admin = new User
        {
            Email = Configurator.AppSettings.Username,
            Password = Configurator.AppSettings.Password
        };

        return Login<DashboardPage>(Admin);
    }

    public LoginPage IncorrectLogin(User user)
    {
        return Login<LoginPage>(user);
    }

    public T Login<T>(User user) where T : BasePage
    {
        LoginPage = new LoginPage();

        LoginPage.EmailInput.SendKeys(user.Email);
        LoginPage.PswInput.SendKeys(user.Password);
        LoginPage.LoginInButton.Click();

        return (T)Activator.CreateInstance(typeof(T), false);
    }
}