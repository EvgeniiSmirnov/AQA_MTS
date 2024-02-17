using PageObjectSauceDemo.Helpers.Configuration;
using PageObjectSauceDemo.Steps;

namespace PageObjectSauceDemo.Tests;

internal class AddToCartTest : BaseTest
{
    // найти товар Sauce Labs Backpack
    // найти кнопку add to cart
    // проверить что нет лейба на количество товара

    // нажать кнопку add to cart
    // проверить что лейбл на количество появился в значении 1

    // кликнуть на корзину
    // проверить что перешли на новую страницу
    // проверить что товар есть в корзине
    // проверить что есть кнопка ремув

    [Test(Description = "Проверка 11")]
    
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
            // отображается кнопка добавить в корзина
            Assert.That(NavigationSteps.InventoryPage.IsAddToCartButtonDisplayed());
            // в корзине нет товаров (счётчик отсутствует)
            Assert.That(NavigationSteps.InventoryPage.IsShoppingCartBadgeInvisible());
        });
        // нажимаем кнопку добавить в корзину
        NavigationSteps.InventoryPage.AddToCartButtonClick();

        Assert.Multiple(() =>
        {
            // проверяем, что:
            // отображается кнопка удалить из корзины
            Assert.That(NavigationSteps.InventoryPage.IsRemoveFromCartButtonDisplayed());
            // в корзине появился товар (счётчик появился)
            Assert.That(NavigationSteps.InventoryPage.IsShoppingCartBadgeDisplayed());
        });



    }
}