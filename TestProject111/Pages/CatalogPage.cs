using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestProject111.Pages;

public class CatalogPage : BasePage
{
    private static string END_POINT = "inventory.html";

    private static readonly By InventoryContainerBy = By.Id("inventory_container");
    private static readonly By SortSelectBy = By.ClassName("product_sort_container");
    private static readonly By ShoppingCartLinkBy = By.ClassName("shopping_cart_link");
    private static readonly By ShoppingCartBadgeBy = By.XPath("//span[@class='shopping_cart_badge']");
    private static readonly By LogoLabelBy = By.ClassName("app_logo");
    private static readonly By ProductImgBy = By.XPath("//*[@id='item_0_img_link']/img");
    private static readonly By ProductTitleLinkBy = By.XPath("//*[@id='item_0_title_link']/div");
    private static readonly By ProductDescriptionBy = By.XPath("//*[@id='item_0_title_link']/following-sibling::div[@class='inventory_item_desc']");
    private static readonly By ProductPriceBy = By.XPath("//*[@id='add-to-cart-sauce-labs-bike-light']/preceding-sibling::div[@class='inventory_item_price']");
    private static readonly By AddToCartButtonBy = By.XPath("//*[@id='item_0_title_link']/descendant::button[@class='btn_inventory']");

    public CatalogPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
    {
    }

    public CatalogPage(IWebDriver driver) : base(driver)
    {
    }

    public override bool IsPageOpened()
    {
        try
        {
            return InventoryContainer.Displayed;
        }
        catch (Exception)
        {
            return false;
        }
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public IWebElement InventoryContainer => WaitsHelper.WaitForExists(InventoryContainerBy);
    public IWebElement SprtSelect => WaitsHelper.WaitForExists(SortSelectBy);
    public IWebElement ShoppingCartLink => WaitsHelper.WaitForExists(ShoppingCartLinkBy);
    public IWebElement ShoppingCartBadge => WaitsHelper.WaitForExists(ShoppingCartBadgeBy);
    public IWebElement LogoLabel => WaitsHelper.WaitForExists(LogoLabelBy);
    public IWebElement ProductImg => WaitsHelper.WaitForExists(ProductImgBy);
    public IWebElement ProductTitleLink => WaitsHelper.WaitForExists(ProductTitleLinkBy);
    public IWebElement ProductDescription => WaitsHelper.WaitForExists(ProductDescriptionBy);
    public IWebElement ProductPrice => WaitsHelper.WaitForExists(ProductPriceBy);
    public IWebElement AddToCartButton => WaitsHelper.WaitForExists(AddToCartButtonBy);
    // public IWebElement RemoveToCartButton => WaitsHelper.WaitForExists(RemoveToCartButtonBy);
}