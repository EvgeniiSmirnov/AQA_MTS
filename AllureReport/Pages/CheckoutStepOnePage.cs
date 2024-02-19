using OpenQA.Selenium;

namespace AllureReport.Pages;

public class CheckoutStepOnePage : BasePage
{
    private static readonly string _endPoint = "/checkout-step-one.html";

    // Описание элементов
    private static readonly By TitleBy = By.XPath("//*[@class='title' and text()='Checkout: Your Information']");
    private static readonly By FirstNameInputBy = By.Id("first-name");
    private static readonly By LastNameInputBy = By.Id("last-name");
    private static readonly By PostalCodeInputBy = By.Id("postal-code");
    private static readonly By ContinueButtonBy = By.Id("continue");

    public CheckoutStepOnePage(IWebDriver? driver) : base(driver) { }
    public CheckoutStepOnePage(IWebDriver? driver, bool openPageByUrl) : base(driver, openPageByUrl) { }

    // Методы
    public IWebElement Title => WaitsHelper.WaitForExists(TitleBy);
    public IWebElement FirstNameInput => WaitsHelper.WaitForExists(FirstNameInputBy);
    public IWebElement LastNameInput => WaitsHelper.WaitForExists(LastNameInputBy);
    public IWebElement PostalCodeInput => WaitsHelper.WaitForExists(PostalCodeInputBy);
    public IWebElement ContinueButton => WaitsHelper.WaitForExists(ContinueButtonBy);

    public void FillData(string firstName, string lastName, string postalCode)
    {
        FirstNameInput.SendKeys(firstName);
        LastNameInput.SendKeys(lastName);
        PostalCodeInput.SendKeys(postalCode);  
    }

    public void ContinueButtonClick() => ContinueButton.Click();    

    public override bool IsPageOpened()
    {
        try
        {
            return Title.Displayed;
        }
        catch (Exception)
        {
            return false;
        }
    }
    protected override string GetEndpoint() => _endPoint;
}