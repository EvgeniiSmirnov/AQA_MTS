using AllureReport.Helpers.Configuration;
using Allure.Net.Commons;
using AllureReport.Steps;
using NUnit.Allure.Attributes;

namespace AllureReport.Tests;

class CheckoutTest : BaseTest
{
    [Test(Description = "Оформление и оплата выбранного товара.")]
    [AllureSeverity(SeverityLevel.normal)]
    public void SuccessCheckoutTest()
    {
        // блок подготовки
        {
            // переходим в корзину
            NavigationSteps.NavigateToCartPage(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

            Assert.Multiple(() =>
            {
                // проверяем, что
                AllureApi.Step("загрузилась страница Cart");
                Assert.That(NavigationSteps.CartPage.IsPageOpened());
                AllureApi.Step("отображается нужный товар");
                Assert.That(NavigationSteps.CartPage.IsSauceLabsBackpackDisplayed());
            });
        }

        // нажимаем кнопку Checkout
        NavigationSteps.NavigateToCheckoutStepOnePage();

        AllureApi.Step("загрузилась страница Checkout Step One");
        Assert.That(NavigationSteps.CheckoutStepOnePage.IsPageOpened());

        AllureApi.Step("заполняем данные о покупателе и кликаем кнопку Continue");
        NavigationSteps.CheckoutStepOnePage.FillData("Happy", "Customer", "123456");
        TakeScreenshot("данные покупателя");
        NavigationSteps.CheckoutStepOnePage.ContinueButtonClick();
        
        Assert.Multiple(() =>
        {
            // проверяем, что
            AllureApi.Step("загрузилась страница Checkout Step Two");
            Assert.That(NavigationSteps.CheckoutStepTwoPage.IsPageOpened());
            AllureApi.Step("отображается нужный товар");
            Assert.That(NavigationSteps.CheckoutStepTwoPage.IsSauceLabsBackpackDisplayed());
            AllureApi.Step("отображается платёжная информация");
            Assert.That(NavigationSteps.CheckoutStepTwoPage.IsPaymentInformationDisplayed());
        });
        TakeScreenshot("платёжная информация");

        AllureApi.Step("нажимаем кнопку Checkout");
        NavigationSteps.CheckoutStepTwoPage.FinishButtonClick();

        Assert.Multiple(() =>
        {
            // проверяем, что
            AllureApi.Step("загрузилась страница Checkout Complete");
            Assert.That(NavigationSteps.CheckoutCompletePage.IsPageOpened());
            AllureApi.Step("отображается сообщение об успешном заказе");
            Assert.That(NavigationSteps.CheckoutCompletePage.IsCompleteHeaderDisplayed());
        });
        TakeScreenshot("сообщение сообщение об успешном заказе");
    }
}