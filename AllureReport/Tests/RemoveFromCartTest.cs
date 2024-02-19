using AllureReport.Helpers.Configuration;
using Allure.Net.Commons;
using NUnit.Allure.Attributes;

namespace AllureReport.Tests;

class RemoveFromCartTest : BaseTest
{
    [Test(Description = "Удаление товара из корзины. Проверка возможности вновь добавить товар")]
    [AllureSeverity(SeverityLevel.normal)]
    public void SuccessRemoveFromCartTest()
    {
        // блок подготовки
        {
            // переходим в корзину
            NavigationSteps.NavigateToCartPage(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

            Assert.Multiple(() =>
            {
                // проверяем, что:
                AllureApi.Step("загрузилась страница Cart");
                Assert.That(NavigationSteps.CartPage.IsPageOpened());
                AllureApi.Step("отображается нужный товар");
                Assert.That(NavigationSteps.CartPage.IsSauceLabsBackpackDisplayed());
                AllureApi.Step("отображается кнопка Remove");
                Assert.That(NavigationSteps.CartPage.IsRemoveFromCartButtonDisplayed());
            });
            TakeScreenshot("корзина с товаром");
        }

        AllureApi.Step("удаляем товар из корзины кнопкой Remove");
        NavigationSteps.CartPage.RemoveFromCartButtonClick();

        Assert.Multiple(() =>
        {
            // проверяем, что:
            AllureApi.Step("товар не отображается");
            Assert.That(NavigationSteps.CartPage.IsSauceLabsBackpackInvisible());
            AllureApi.Step("кнопка Remove не отображается");
            Assert.That(NavigationSteps.CartPage.IsRemoveFromCartButtonInvisible());
        });
        TakeScreenshot("товар удалён из корзины");

        // возвращаемся на страницу Inventory по клику на кнопку Continue Shopping
        AllureApi.Step("возвращаемся на страницу Inventory");
        NavigationSteps.CartPage.ContinueShoppingButtonClick();

        Assert.Multiple(() =>
        {
            // проверяем, что:
            AllureApi.Step("загрузилась страница Inventory");
            Assert.That(NavigationSteps.InventoryPage.IsPageOpened());
            AllureApi.Step("для нужного товара вновь отображается кнопка Add to cart");
            Assert.That(NavigationSteps.InventoryPage.IsAddToCartButtonDisplayed());
        });
        TakeScreenshot("товар внонь доступен для добавления в корзину");
    }
}