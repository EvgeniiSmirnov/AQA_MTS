using OpenQA.Selenium;
using PageObjectStepsSauceDemo.Helpers;
using PageObjectStepsSauceDemo.Pages;

namespace PageObjectStepsSauceDemo.Steps;

public class BaseStep(IWebDriver driver)
{
    protected IWebDriver Driver { get; set; } = driver;
    protected WaitsHelper WaitsHelper { get; set; }

    public LoginPage LoginPage => new(Driver);

    public InventoryPage InventoryPage => new(Driver, true);

    public CartPage CartPage => new(Driver, true);

    public CheckoutStepOnePage CheckoutStepOnePage => new(Driver, true);

    public CheckoutStepTwoPage CheckoutStepTwoPage => new(Driver, true);

    public CheckoutCompletePage CheckoutCompletePage => new(Driver, true);
}