using OpenQA.Selenium;

namespace PageObjectSauceDemo.Pages;

public class InventoryPage : BasePage
{
    private static readonly string _endPoint = "/inventory.html";

    // Описание элементов
    private static readonly By TitleBy = By.XPath("//*[@class='title' and text()='Products']");

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


}