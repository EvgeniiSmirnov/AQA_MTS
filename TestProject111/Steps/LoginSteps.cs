using OpenQA.Selenium;
using TestProject111.Pages;

namespace TestProject111.Steps;

public  class LoginSteps : BaseStep
{
    public LoginSteps(IWebDriver driver) : base(driver)
    {
    }

    public LoginPage NavigateToLoginPage()
    {
        return new LoginPage(Driver, true);
    }

    public CatalogPage NavigateToCatalogPage()
    {
        return new CatalogPage(Driver, true);
    }

    public CatalogPage SuccessfulLogin(string username, string psw)
    {
        Login(username, psw);
        return CatalogPage;
    }

    public LoginPage IncorrectLogin(string username, string psw)
    {
        Login(username, psw);
        return LoginPage;
    }

    public string ErorrText()
    {
        return LoginPage.ErrorContainer.Text;
    }

    private void Login(string username, string psw)
    {
        LoginPage.EmailInput.SendKeys(username);
        LoginPage.PswInput.SendKeys(psw);
        LoginPage.LoginButtonClick();
    }
}