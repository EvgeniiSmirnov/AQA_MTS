using OpenQA.Selenium;
using TestProject111.Pages;

namespace TestProject111.Steps;

public class BaseStep
{
    protected IWebDriver Driver;

    public LoginPage LoginPage => new LoginPage(Driver);
    public CatalogPage CatalogPage => new CatalogPage(Driver, true);
    //public CartPage CartPage => new CartPage(Driver, false);

    public BaseStep(IWebDriver driver)
    {
        Driver = driver;
    }
}