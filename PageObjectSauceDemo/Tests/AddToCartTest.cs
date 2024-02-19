using Allure.Helpers.Configuration;
using Allure.Net.Commons;
using Allure.Steps;
using NUnit.Allure.Attributes;

namespace Allure.Tests;

class AddToCartTest : BaseTest
{
    [Test(Description = "Добавление товара в корзину. Проверка наличия товара в корзине")]
    [AllureSeverity(SeverityLevel.normal)]
    public void SuccessAddToCartTest()
    {
        NavigationSteps.NavigateToLoginPage();
        NavigationSteps.Login(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        Assert.Multiple(() =>
        {
            // Проверяем, что
            AllureApi.Step("загрузилась страница Inventory");
            Assert.That(NavigationSteps.InventoryPage.IsPageOpened());
            AllureApi.Step("отображается нужный товар");
            Assert.That(NavigationSteps.InventoryPage.IsSauceLabsBackpackDisplayed());
            AllureApi.Step("отображается кнопка Add to cart");
            Assert.That(NavigationSteps.InventoryPage.IsAddToCartButtonDisplayed());
            AllureApi.Step("в корзине нет товаров (счётчик отсутствует)");
            Assert.That(NavigationSteps.InventoryPage.IsShoppingCartBadgeInvisible());
        });
        TakeScreenshot("Страница Inventory до добавления товара в корзину");

        AllureApi.Step("нажимаем кнопку Add to cart");
        NavigationSteps.InventoryPage.AddToCartButtonClick();

        Assert.Multiple(() =>
        {
            // проверяем, что:
            AllureApi.Step("отображается кнопка Remove");
            Assert.That(NavigationSteps.InventoryPage.IsRemoveFromCartButtonDisplayed());
            AllureApi.Step("в корзине появился товар (счётчик появился)");
            Assert.That(NavigationSteps.InventoryPage.IsShoppingCartBadgeDisplayed());
            AllureApi.Step("перестала отображаться кнопка Add to cart");
            Assert.That(NavigationSteps.InventoryPage.IsAddToCartButtonInvisible());
        });
        TakeScreenshot("Страница Inventory после добавления товара в корзину");

        // переходим в корзину по клику
        NavigationSteps.NavigateToCartPage();

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
        TakeScreenshot("Страница Cart. Товар добавлен");
    }
}