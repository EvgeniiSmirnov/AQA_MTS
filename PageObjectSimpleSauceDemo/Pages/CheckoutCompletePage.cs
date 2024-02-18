using OpenQA.Selenium;
using PageObjectSimpleSauceDemo.Helpers;

namespace PageObjectSimpleSauceDemo.Pages;

public class CheckoutCompletePage : BasePage
{
    private static readonly string _endPoint = "/checkout-complete.html";

    // Описание элементов
    private static readonly By TitleBy = By.XPath("//*[@class='title' and text()='Checkout: Complete!']");
    private static readonly By CompleteHeaderBy = By.XPath("//*[@class='complete-header' and text()='Thank you for your order!']");

    public CheckoutCompletePage(IWebDriver? driver) : base(driver) { }
    public CheckoutCompletePage(IWebDriver? driver, bool openPageByUrl) : base(driver, openPageByUrl) { }

    // Методы
    public IWebElement Title => WaitsHelper.WaitForExists(TitleBy);
    public IWebElement CompleteHeader => WaitsHelper.WaitForExists(CompleteHeaderBy);
    public bool IsCompleteHeaderDisplayed() => CompleteHeader.Displayed;

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