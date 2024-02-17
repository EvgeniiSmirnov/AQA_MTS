using OpenQA.Selenium;

namespace PageObjectSauceDemo.Pages;

public class CheckoutStepTwoPage : BasePage
{
    private static readonly string _endPoint = "/checkout-step-two.html";

    // Описание элементов
    private static readonly By TitleBy = By.XPath("//*[@class='title' and text()='Checkout: Overview']");
    private static readonly By SauceLabsBackpackBy = By.XPath("//*[@class='inventory_item_name ' and text()='Sauce Labs Backpack']");

    public CheckoutStepTwoPage(IWebDriver? driver) : base(driver) { }
    public CheckoutStepTwoPage(IWebDriver? driver, bool openPageByUrl) : base(driver, openPageByUrl) { }

    // Методы
    public IWebElement Title => WaitsHelper.WaitForExists(TitleBy);




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