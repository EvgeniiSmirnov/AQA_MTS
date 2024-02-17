using OpenQA.Selenium;

namespace PageObjectSauceDemo.Pages;

public class LoginPage : BasePage
{
    private static readonly string _endPoint = "";

    // Описание элементов
    private static readonly By UsernameInputBy = By.Id("user-name");
    private static readonly By PasswordInputBy = By.Id("password");
    private static readonly By LoginButtonBy = By.Id("login-button");
    private static readonly By ErrorContainerBy = By.ClassName("error-message-container");

    // Инициализация класса
    public LoginPage(IWebDriver driver) : base(driver, false) { }
    public LoginPage(IWebDriver driver, bool openPageByUrl = false) : base(driver, openPageByUrl) { }

    public override bool IsPageOpened()
    {
        try
        {
            return LoginButton.Displayed;
        }
        catch (Exception)
        {
            return false;
        }

    }

    protected override string GetEndpoint() => _endPoint;

    // Методы
    public IWebElement UsernameInput => WaitsHelper.WaitForExists(UsernameInputBy);
    public IWebElement PasswordInput => WaitsHelper.WaitForExists(PasswordInputBy);
    public IWebElement LoginButton => WaitsHelper.WaitForExists(LoginButtonBy);
    public IWebElement ErrorContainer => WaitsHelper.WaitForExists(ErrorContainerBy);

    public void LoginButtonClick()
    {
        LoginButton.Click();
    }

    public InventoryPage Login(string username, string password)
    {
        UsernameInput.SendKeys(username);
        PasswordInput.SendKeys(password);
        LoginButton.Click();

        return new InventoryPage(Driver);
    }

    public LoginPage Login1(string username, string password)
    {
        UsernameInput.SendKeys(username);
        PasswordInput.SendKeys(password);
        LoginButton.Click();

        return new LoginPage(Driver); ;
    }
}
