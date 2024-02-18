using PageObjectSimpleSauceDemo.Helpers.Configuration;
using PageObjectSimpleSauceDemo.Pages;

namespace PageObjectSimpleSauceDemo.Tests;

class RemoveFromCartTest : BaseTest
{
    [Test(Description = "Удаление товара из корзины. Проверка возможности вновь добавить товар")]
    public void SuccessRemoveFromCartTest()
    {
        CartPage cartPage;
        InventoryPage inventoryPage;
        // блок подготовки
        {
            inventoryPage = new LoginPage(Driver, true)
                .Login(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
            
            Assert.Multiple(() =>
            {
                // проверяем, что:
                // загрузилась страница Inventory
                Assert.That(inventoryPage.IsPageOpened());
                // отображается нужный товар
                Assert.That(inventoryPage.IsSauceLabsBackpackDisplayed());
            });

            // нажимаем кнопку Add to cart
            inventoryPage.AddToCartButtonClick();

            // переходим в корзину по клику
            inventoryPage.ShoppingCartClick();

            cartPage = new(Driver, true);

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

        // удаляем товар из корзины кнопкой Remove
        cartPage.RemoveFromCartButtonClick();

        Assert.Multiple(() =>
        {
            // проверяем, что:
            // товар не отображается
            Assert.That(cartPage.IsSauceLabsBackpackInvisible());
            // кнопка Remove не отображается
            Assert.That(cartPage.IsRemoveFromCartButtonInvisible());
        });

        // возвращаемся на страницу Inventory по клику на кнопку Continue Shopping
        cartPage.ContinueShoppingButtonClick();

        Assert.Multiple(() =>
        {
            // проверяем, что:
            // загрузилась страница Inventory
            Assert.That(inventoryPage.IsPageOpened());
            // для нужного товара вновь отображается кнопка Add to cart
            Assert.That(inventoryPage.IsAddToCartButtonDisplayed());
        });
    }
}