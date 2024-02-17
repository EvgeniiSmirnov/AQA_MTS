using OpenQA.Selenium;
using PageObjectSauceDemo.Pages;


namespace PageObjectSauceDemo.Steps;

public class BaseStep
{
    protected IWebDriver Driver;

    public LoginPage LoginPage => new LoginPage(Driver);
    //public InventoryPage CatalogPage => new InventoryPage(Driver, true);

    public BaseStep(IWebDriver driver)
    {
        Driver = driver;
    }
}