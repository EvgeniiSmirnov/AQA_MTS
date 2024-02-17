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
            Assert.That(NavigationSteps.InventoryPage.IsPageOpened());
            Assert.That(NavigationSteps.InventoryPage.SauceLabsBackpack.Displayed);
            Assert.That(NavigationSteps.InventoryPage.AddToCartButton.Displayed);
            Assert.That(NavigationSteps.InventoryPage.IsInvisibleShoppingCartBadge);
        });
        
    }
}