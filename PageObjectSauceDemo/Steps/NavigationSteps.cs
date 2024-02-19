using OpenQA.Selenium;
using Allure.Pages;
using NUnit.Allure.Attributes;

namespace Allure.Steps;

public class NavigationSteps(IWebDriver driver) : BaseStep(driver)
{
    [AllureStep("Переходим на страницу авторизации")]
    public LoginPage NavigateToLoginPage()
    {
        return new LoginPage(Driver, true);
    }

    [AllureStep("Вводим username и password")]
    public InventoryPage Login(string username, string password)
    {
        LoginWith(username, password);
        return new InventoryPage(Driver);
    }

    [AllureStep("Переходим в корзину")]
    public CartPage NavigateToCartPage()
    {
        InventoryPage.ShoppingCart.Click();
        return new CartPage(Driver);
    }

    [AllureStep("Переходим в корзину")]
    public CartPage NavigateToCartPage(string username, string password)
    {
        NavigateToLoginPage();
        Login(username, password);
        InventoryPage.ShoppingCart.Click();
        // нажимаем кнопку Add to cart
        InventoryPage.AddToCartButtonClick();
        return new CartPage(Driver);
    }

    [AllureStep("Переходим на страницу заказа")]
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