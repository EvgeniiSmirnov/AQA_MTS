using OpenQA.Selenium;

namespace PageObjectSimpleSauceDemo.Pages;

public class CheckoutStepTwoPage : BasePage
{
    private static readonly string _endPoint = "/checkout-step-two.html";

    // Описание элементов
    private static readonly By TitleBy = By.XPath("//*[@class='title' and text()='Checkout: Overview']");
    private static readonly By SauceLabsBackpackBy = By.XPath("//*[@class='inventory_item_name' and text()='Sauce Labs Backpack']");
    private static readonly By PaymentInformationBy = By.XPath("//*[@class='summary_info_label' and text()='Payment Information']");
    private static readonly By TotalBy = By.XPath("//div[contains(text(),'Total: $')]");
    private static readonly By FinishButtonBy = By.Id("finish");
    public CheckoutStepTwoPage(IWebDriver? driver) : base(driver) { }
    public CheckoutStepTwoPage(IWebDriver? driver, bool openPageByUrl) : base(driver, openPageByUrl) { }

    // Методы
    public IWebElement Title => WaitsHelper.WaitForExists(TitleBy);

    public IWebElement SauceLabsBackpack => WaitsHelper.WaitForExists(SauceLabsBackpackBy);
    public bool IsSauceLabsBackpackDisplayed() => IsElementDisplayed(SauceLabsBackpack);

    public IWebElement PaymentInformation => WaitsHelper.WaitForExists(PaymentInformationBy);
    public IWebElement Total => WaitsHelper.WaitForExists(TotalBy);

    public bool IsPaymentInformationDisplayed()
    {
        return (IsElementDisplayed(PaymentInformation) && IsElementDisplayed(Total));
    }

    public IWebElement FinishButton => WaitsHelper.WaitForExists(FinishButtonBy);
    public void FinishButtonClick() => FinishButton.Click();

    private bool IsElementDisplayed(IWebElement webElement) => webElement.Displayed;

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