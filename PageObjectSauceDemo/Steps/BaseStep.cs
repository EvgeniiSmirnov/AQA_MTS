using OpenQA.Selenium;
using PageObjectSauceDemo.Helpers;
using PageObjectSauceDemo.Pages;

namespace PageObjectSauceDemo.Steps;

public class BaseStep(IWebDriver driver)
{
    protected IWebDriver Driver { get; set; } = driver;
    protected WaitsHelper WaitsHelper { get; set; }

    public LoginPage LoginPage => new(Driver);

    public InventoryPage InventoryPage => new(Driver, true);

    public CartPage CartPage => new(Driver, true);

    public CheckoutStepOnePage CheckoutStepOnePage => new(Driver, true);
}