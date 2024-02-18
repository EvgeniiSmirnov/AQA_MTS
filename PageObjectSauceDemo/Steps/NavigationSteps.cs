using OpenQA.Selenium;
using PageObjectSauceDemo.Pages;

namespace PageObjectSauceDemo.Steps;

public class NavigationSteps(IWebDriver driver) : BaseStep(driver)
{
    public LoginPage NavigateToLoginPage()
    {
        return new LoginPage(Driver, true);
    }

    public InventoryPage Login(string username, string password)
    {
        LoginWith(username, password);
        return new InventoryPage(Driver);
    }

    public CartPage NavigateToCartPage()
    {
        InventoryPage.ShoppingCart.Click();
        return new CartPage(Driver);
    }
    public CartPage NavigateToCartPage(string username, string password)
    {
        NavigateToLoginPage();
        Login(username, password);
        InventoryPage.ShoppingCart.Click();
        // нажимаем кнопку Add to cart
        InventoryPage.AddToCartButtonClick();
        return new CartPage(Driver);
    }

    public CheckoutStepOnePage NavigateToCheckoutStepOnePage()
    {
        CartPage.CheckoutButton.Click();
        return new CheckoutStepOnePage(Driver);
    }

    private void LoginWith(string username, string password)
    {
        LoginPage.UsernameInput.SendKeys(username);
        LoginPage.PasswordInput.SendKeys(password);
        LoginPage.LoginButton.Click();
    }
}