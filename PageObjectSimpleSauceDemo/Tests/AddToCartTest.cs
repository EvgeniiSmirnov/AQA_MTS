using PageObjectSimpleSauceDemo.Helpers.Configuration;
using PageObjectSimpleSauceDemo.Pages;

namespace PageObjectSimpleSauceDemo.Tests;

class AddToCartTest : BaseTest
{
    [Test(Description = "Добавление товара в корзину. Проверка наличия товара в корзине")]
    public void SuccessAddToCartTest()
    {
        InventoryPage inventoryPage = new LoginPage(Driver, true)
            .Login(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        
        Assert.Multiple(() =>
        {
            // проверяем, что после логина открылась ожидаемая страница
            Assert.That(inventoryPage.IsPageOpened());
                    
            // проверяем, что:
            // загрузилась страница Inventory
            Assert.That(inventoryPage.IsPageOpened());
            // отображается нужный товар
            Assert.That(inventoryPage.IsSauceLabsBackpackDisplayed());
            // отображается кнопка Add to cart
            Assert.That(inventoryPage.IsAddToCartButtonDisplayed());
            // в корзине нет товаров (счётчик отсутствует)
            Assert.That(inventoryPage.IsShoppingCartBadgeInvisible());
        });

        // нажимаем кнопку Add to cart
        inventoryPage.AddToCartButtonClick();

        Assert.Multiple(() =>
        {
            // проверяем, что:
            // отображается кнопка Remove
            Assert.That(inventoryPage.IsRemoveFromCartButtonDisplayed());
            // в корзине появился товар (счётчик появился)
            Assert.That(inventoryPage.IsShoppingCartBadgeDisplayed());
            // перестала отображаться кнопка Add to cart
            Assert.That(inventoryPage.IsAddToCartButtonInvisible());
        });

        // переходим в корзину по клику
        inventoryPage.ShoppingCartClick();

        CartPage cartPage = new(Driver, true);

        Assert.Multiple(() =>
        {
            // проверяем, что:
            // загрузилась страница Cart
            Assert.That(cartPage.IsPageOpened());
            // отображается нужный товар
            Assert.That(cartPage.IsSauceLabsBackpackDisplayed());
            // отображается кнопка Remove
            Assert.That(cartPage.IsRemoveFromCartButtonDisplayed());
        });
    }
}