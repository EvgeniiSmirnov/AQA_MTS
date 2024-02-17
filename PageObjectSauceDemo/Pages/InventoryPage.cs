using OpenQA.Selenium;

namespace PageObjectSauceDemo.Pages;

public class InventoryPage : BasePage
{
    private static readonly string _endPoint = "/inventory.html";

    // Описание элементов
    private static readonly By TitleBy = By.XPath("//*[@class='title' and text()='Products']");
    private static readonly By SauceLabsBackpackBy = By.XPath("//*[@class='inventory_item_name ' and text()='Sauce Labs Backpack']");
    private static readonly By AddToCartButtonBy = By.Id("add-to-cart-sauce-labs-backpack");
    private static readonly By RemoveFromCartButtonBy = By.Id("remove-sauce-labs-backpack");
    private static readonly By ShoppingCartBy = By.ClassName("shopping_cart_link");
    private static readonly By ShoppingCartBadgeBy = By.ClassName("shopping_cart_badge");

    public InventoryPage(IWebDriver? driver) : base(driver) { }
    public InventoryPage(IWebDriver? driver, bool openPageByUrl) : base(driver, openPageByUrl) { }

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

    public IWebElement AddToCartButton => WaitsHelper.WaitForExists(AddToCartButtonBy);
    public bool IsAddToCartButtonDisplayed() => IsElementDisplayed(AddToCartButton);
    public bool IsAddToCartButtonInvisible() => WaitsHelper.WaitForElementInvisible(AddToCartButtonBy);
    public void AddToCartButtonClick() => AddToCartButton.Click();

    public IWebElement ShoppingCartBadge => WaitsHelper.WaitForExists(ShoppingCartBadgeBy);
    public bool IsShoppingCartBadgeDisplayed() => IsElementDisplayed(ShoppingCartBadge);
    public bool IsShoppingCartBadgeInvisible() => WaitsHelper.WaitForElementInvisible(ShoppingCartBadgeBy);

    public IWebElement RemoveFromCartButton => WaitsHelper.WaitForExists(RemoveFromCartButtonBy);
    public bool IsRemoveFromCartButtonDisplayed() => IsElementDisplayed(RemoveFromCartButton);
    
    public IWebElement ShoppingCart => WaitsHelper.WaitForExists(ShoppingCartBy);
    public void ShoppingCartClick() => ShoppingCart.Click();

    private bool IsElementDisplayed(IWebElement webElement) => webElement.Displayed;
}