/*Задание 1: Добавить тест для страницы Context Menu
Правый клик по элементу
Валидация текста на алерте
Закрытие алерта
*/

using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SeleniumAdvanced.Tests;

class Task1 : BaseTest
{
    [Test]
    public void ContextMenuTest()
    {
        // переходим на страницу Context Menu по линкклику 
        WaitsHelper.WaitForVisibilityLocatedBy(By.LinkText("Context Menu")).Click();

        // правый клик по элементу
        new Actions(Driver)
            .MoveToElement(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("hot-spot")), 25, 25)
            .ContextClick()
            .Build()
            .Perform();

        // обработка алерта
        IAlert alert = Driver.SwitchTo().Alert();

        Assert.That(alert.Text, Is.EqualTo("You selected a context menu"));
        alert.Accept();

        Thread.Sleep(3000);
    }
}