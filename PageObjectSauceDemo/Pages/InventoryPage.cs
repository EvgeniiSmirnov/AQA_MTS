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

    public IWebElement TitleLable => WaitsHelper.WaitForExists(TitleBy);
    //public BackpackItemSmall BackpackItemSmall() => new BackpackItemSmall(Driver);
    //public BikeLiteItemSmall BikeLiteItemSmall() => new BikeLiteItemSmall(Driver);

    public override bool IsPageOpened()
    {
        try
        {
            return TitleLable.Displayed;
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
    public IWebElement AddToCartButton => WaitsHelper.WaitForExists(AddToCartButtonBy);
    public IWebElement RemoveFromCartButton => WaitsHelper.WaitForExists(RemoveFromCartButtonBy);
    public IWebElement ShoppingCart => WaitsHelper.WaitForExists(ShoppingCartBy);
    public bool IsInvisibleShoppingCartBadge
    {
        get
        {
            return WaitsHelper.WaitForElementInvisible(ShoppingCartBadgeBy);
        }
    }

    //public IWebElement ShoppingCartBadge2 = Driver.FindElement(ShoppingCartBadgeBy);
}