using Allure.Helpers.Configuration;

namespace Allure.Tests;

class RemoveFromCartTest : BaseTest
{
    [Test(Description = "Удаление товара из корзины. Проверка возможности вновь добавить товар")]
    public void SuccessRemoveFromCartTest()
    {
        // блок подготовки
        {
            // переходим в корзину
            NavigationSteps.NavigateToCartPage(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

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

        // удаляем товар из корзины кнопкой Remove
        NavigationSteps.CartPage.RemoveFromCartButtonClick();

        Assert.Multiple(() =>
        {
            // проверяем, что:
            // товар не отображается
            Assert.That(NavigationSteps.CartPage.IsSauceLabsBackpackInvisible());
            // кнопка Remove не отображается
            Assert.That(NavigationSteps.CartPage.IsRemoveFromCartButtonInvisible());
        });

        // возвращаемся на страницу Inventory по клику на кнопку Continue Shopping
        NavigationSteps.CartPage.ContinueShoppingButtonClick();

        Assert.Multiple(() =>
        {
            // проверяем, что:
            // загрузилась страница Inventory
            Assert.That(NavigationSteps.InventoryPage.IsPageOpened());
            // для нужного товара вновь отображается кнопка Add to cart
            Assert.That(NavigationSteps.InventoryPage.IsAddToCartButtonDisplayed());
        });
    }
}