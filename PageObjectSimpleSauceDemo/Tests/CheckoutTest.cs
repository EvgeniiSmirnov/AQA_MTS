using PageObjectSauceDemo.Helpers.Configuration;

namespace PageObjectSauceDemo.Tests;

class CheckoutTest : BaseTest
{
    [Test(Description = "Оформление и оплата выбранного товара.")]
    public void SuccessCheckoutTest()
    {
        // блок подготовки
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
            });

            // нажимаем кнопку Add to cart
            NavigationSteps.InventoryPage.AddToCartButtonClick();

            // переходим в корзину по клику
            NavigationSteps.InventoryPage.ShoppingCartClick();

            Assert.Multiple(() =>
            {
                // проверяем, что:
                // загрузилась страница Cart
                Assert.That(NavigationSteps.CartPage.IsPageOpened());
                // отображается нужный товар
                Assert.That(NavigationSteps.CartPage.IsSauceLabsBackpackDisplayed());
            });
        }

        // нажимаем кнопку Checkout
        NavigationSteps.CartPage.CheckoutButtonClick();

        // проверяем, что загрузилась страница Checkout Step One
        Assert.That(NavigationSteps.CheckoutStepOnePage.IsPageOpened());

        // заполняем данные о покупателе и кликаем кнопку Continue
        NavigationSteps.CheckoutStepOnePage.FillDataAndClickContinueButton("Happy", "Customer", "123456");

        Assert.Multiple(() =>
        {
            // проверяем, что
            // загрузилась страница Checkout Step Two
            Assert.That(NavigationSteps.CheckoutStepTwoPage.IsPageOpened());
            // отображается нужный товар
            Assert.That(NavigationSteps.CheckoutStepTwoPage.IsSauceLabsBackpackDisplayed());
            // отображается платёжная информация
            Assert.That(NavigationSteps.CheckoutStepTwoPage.IsPaymentInformationDisplayed());
        });

        // нажимаем кнопку Checkout
        NavigationSteps.CheckoutStepTwoPage.FinishButtonClick();

        Assert.Multiple(() =>
        {
            // проверяем, что
            // загрузилась страница Checkout Complete
            Assert.That(NavigationSteps.CheckoutCompletePage.IsPageOpened());
            // отображается сообщение об успешном заказе
            Assert.That(NavigationSteps.CheckoutCompletePage.IsCompleteHeaderDisplayed());
        });
    }
}