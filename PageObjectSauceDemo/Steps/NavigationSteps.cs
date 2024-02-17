using OpenQA.Selenium;
using PageObjectSauceDemo.Pages;

namespace PageObjectSauceDemo.Steps;

public class NavigationSteps(IWebDriver driver) : BaseStep(driver)
{
    public LoginPage NavigateToLoginPage()
    {
        return new LoginPage(Driver, true);
    }

    public InventoryPage Login(string username, string password)
    {
        LoginWith(username, password);
        return new InventoryPage(Driver);
    }

    public LoginPage UnSuccessLogin(string username, string password)
    {
        LoginWith(username, password);
        return LoginPage;
    }

    private void LoginWith(string username, string password)
    {
        LoginPage.UsernameInput.SendKeys(username);
        LoginPage.PasswordInput.SendKeys(password);
        LoginPage.LoginButton.Click();
    }
}