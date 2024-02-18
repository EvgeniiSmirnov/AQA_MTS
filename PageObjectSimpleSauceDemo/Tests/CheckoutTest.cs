using PageObjectSimpleSauceDemo.Helpers.Configuration;
using PageObjectSimpleSauceDemo.Pages;

namespace PageObjectSimpleSauceDemo.Tests;

class CheckoutTest : BaseTest
{
    [Test(Description = "Оформление и оплата выбранного товара.")]
    public void SuccessCheckoutTest()
    {
        CartPage cartPage;
        // блок подготовки
        {
            InventoryPage inventoryPage = new LoginPage(Driver, true)
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
            });
        }

        // нажимаем кнопку Checkout
        cartPage.CheckoutButtonClick();

        CheckoutStepOnePage checkoutStepOnePage = new(Driver, true);

        // проверяем, что загрузилась страница Checkout Step One
        Assert.That(checkoutStepOnePage.IsPageOpened());

        // заполняем данные о покупателе и кликаем кнопку Continue
        checkoutStepOnePage.FillDataAndClickContinueButton("Happy", "Customer", "123456");

        CheckoutStepTwoPage checkoutStepTwoPage = new(Driver, true);

        Assert.Multiple(() =>
        {
            // проверяем, что
            // загрузилась страница Checkout Step Two
            Assert.That(checkoutStepTwoPage.IsPageOpened());
            // отображается нужный товар
            Assert.That(checkoutStepTwoPage.IsSauceLabsBackpackDisplayed());
            // отображается платёжная информация
            Assert.That(checkoutStepTwoPage.IsPaymentInformationDisplayed());
        });

        // нажимаем кнопку Checkout
        checkoutStepTwoPage.FinishButtonClick();

        CheckoutCompletePage checkoutCompletePage = new(Driver, true);

        Assert.Multiple(() =>
        {
            // проверяем, что
            // загрузилась страница Checkout Complete
            Assert.That(checkoutCompletePage.IsPageOpened());
            // отображается сообщение об успешном заказе
            Assert.That(checkoutCompletePage.IsCompleteHeaderDisplayed());
        });
    }
}