using PageObjectSauceDemo.Helpers.Configuration;
using PageObjectSauceDemo.Steps;

namespace PageObjectSauceDemo.Tests;

internal class AddToCartTest : BaseTest
{
    [Test(Description = "Добавление товара в корзину. Проверка наличия товара в корзине")]
    public void UserLoginTest()
    {
        NavigationSteps.NavigateToLoginPage();
        NavigationSteps.Login(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        Assert.Multiple(() =>
        {
            // проверяем, что:
            // загрузилась страница Inventory
            Assert.That(NavigationSteps.InventoryPage.IsPageOpened());
            // отображается нужный товар
            Assert.That(NavigationSteps.InventoryPage.IsSauceLabsBackpackDisplayed());
            // отображается кнопка Add to cart
            Assert.That(NavigationSteps.InventoryPage.IsAddToCartButtonDisplayed());
            // в корзине нет товаров (счётчик отсутствует)
            Assert.That(NavigationSteps.InventoryPage.IsShoppingCartBadgeInvisible());
        });

        // нажимаем кнопку добавить в корзину
        NavigationSteps.InventoryPage.AddToCartButtonClick();

        Assert.Multiple(() =>
        {
            // проверяем, что:
            // отображается кнопка Remove
            Assert.That(NavigationSteps.InventoryPage.IsRemoveFromCartButtonDisplayed());
            // в корзине появился товар (счётчик появился)
            Assert.That(NavigationSteps.InventoryPage.IsShoppingCartBadgeDisplayed());
            // перестала отображаться кнопка Add to cart
            Assert.That(NavigationSteps.InventoryPage.IsAddToCartButtonInvisible());
        });

        // переходим в корзину по клику
        NavigationSteps.InventoryPage.ShoppingCartClick();

        Assert.Multiple(() =>
        {
            // проверяем, что:
            // загрузилась страница Cart
            Assert.That(NavigationSteps.CartPage.IsPageOpened());
            // отображается нужный товар
            Assert.That(NavigationSteps.CartPage.IsSauceLabsBackpackDisplayed());
            // отображается кнопка Remove
            Assert.That(NavigationSteps.CartPage.IsRemoveFromCartButtonDisplayed());
        });
    }
}