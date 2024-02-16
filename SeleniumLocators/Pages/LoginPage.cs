using OpenQA.Selenium;

namespace PageObject.Pages
{
    public class LoginPage : BasePage
    {
        private static string END_POINT = "";
        
        // Описание элементов
        private static readonly By EmailInputBy = By.Id("name");
        private static readonly By PswInputBy = By.Id("password");
        private static readonly By RememberMeCheckboxBy = By.Id("rememberme");
        private static readonly By LoginInButtonBy = By.Id("button_primary");
        private static readonly By ErrorLabelBy = By.CssSelector("[data-testid='loginErrorText']");
        
        // Инициализация класса
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }
        
        // Методы
        public IWebElement EmailInput => WaitsHelper.WaitForExists(EmailInputBy);  
        public IWebElement ErrorLabel => WaitsHelper.WaitForExists(ErrorLabelBy);  
        public IWebElement PswInput => WaitsHelper.WaitForExists(PswInputBy);
        public IWebElement RememberMeCheckbox => WaitsHelper.WaitForExists(RememberMeCheckboxBy);  
        public IWebElement LoginInButton => WaitsHelper.WaitForExists(LoginInButtonBy);

        // Комплексные
        public DashboardPage SuccessFulLogin(string username, string password)
        {
            EmailInput.SendKeys(username);
            PswInput.SendKeys(password);
            LoginInButton.Click();

            return new DashboardPage(Driver);
        }

        public LoginPage IncorrectLogin(string username, string password)
        {
            EmailInput.SendKeys(username);
            PswInput.SendKeys(password);
            LoginInButton.Click();

            return this;
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public override bool IsPageOpened()
        {
            return LoginInButton.Displayed && EmailInput.Displayed;
        }
    }
}