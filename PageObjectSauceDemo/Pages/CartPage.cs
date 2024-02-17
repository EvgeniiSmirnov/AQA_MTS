using OpenQA.Selenium;

namespace PageObjectSauceDemo.Pages;

public class CartPage : BasePage
{
    private static readonly string _endPoint = "/cart.html";

    // Описание элементов
    private static readonly By TitleBy = By.XPath("//*[@class='title' and text()='Your Cart']");
    private static readonly By SauceLabsBackpackBy = By.XPath("//*[@class='inventory_item_name' and text()='Sauce Labs Backpack']");
    private static readonly By RemoveFromCartButtonBy = By.Id("remove-sauce-labs-backpack");
    private static readonly By ContinueShoppingButtonBy = By.Id("continue-shopping");


    public CartPage(IWebDriver? driver) : base(driver) { }
    public CartPage(IWebDriver? driver, bool openPageByUrl) : base(driver, openPageByUrl) { }

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

    // Методы
    public IWebElement Title => WaitsHelper.WaitForExists(TitleBy);
    public IWebElement SauceLabsBackpack => WaitsHelper.WaitForExists(SauceLabsBackpackBy);
    public bool IsSauceLabsBackpackDisplayed() => IsElementDisplayed(SauceLabsBackpack);
    public bool IsSauceLabsBackpackInvisible() => WaitsHelper.WaitForElementInvisible(SauceLabsBackpackBy);

    public IWebElement RemoveFromCartButton => WaitsHelper.WaitForExists(RemoveFromCartButtonBy);
    public bool IsRemoveFromCartButtonDisplayed() => IsElementDisplayed(RemoveFromCartButton);
    public bool IsRemoveFromCartButtonInvisible() => WaitsHelper.WaitForElementInvisible(RemoveFromCartButtonBy);
    public void RemoveFromCartButtonClick() => RemoveFromCartButton.Click();

    public IWebElement ContinueShoppingButton => WaitsHelper.WaitForExists(ContinueShoppingButtonBy);
    public void ContinueShoppingButtonClick() => ContinueShoppingButton.Click();

    private bool IsElementDisplayed(IWebElement webElement) => webElement.Displayed;
}