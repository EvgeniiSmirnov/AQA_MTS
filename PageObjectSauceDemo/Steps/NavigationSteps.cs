using OpenQA.Selenium;
using PageObjectSauceDemo.Pages;

namespace PageObjectSauceDemo.Steps;

public class NavigationSteps : BaseStep
{
    public NavigationSteps(IWebDriver driver) : base(driver) { }
    
    public LoginPage NavigateToLoginPage()
    {
        return new LoginPage(Driver, true);
    }

    //public LoginPage IncorrectLogin(string username, string psw)
    //{
    //    Login(username, psw);
    //    return LoginPage;
    //}

    //private void Login(string username, string psw)
    //{
    //    LoginPage.EmailInput().SendKeys(username);
    //    LoginPage.PswInput().SendKeys(psw);
    //    LoginPage.LoginInButton().Click();
    //}

}