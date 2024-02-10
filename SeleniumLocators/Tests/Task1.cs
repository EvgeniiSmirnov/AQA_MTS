/*Задание 2: Добавить тест для страницы Dynamic Controls
Нажать на кнопку Remove около чекбокса
Дождаться надписи “It’s gone”
Проверить, что чекбокса нет
Найти инпут
Проверить, что он disabled
Нажать на кнопку
Дождаться надписи “It's enabled!”
Проверить, что инпут enabled

*/

using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SeleniumAdvanced.Tests;

class Task1 : BaseTest
{
    [Test(Description = "Task 1 (Context Menu)")]
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
    }

    [Test(Description = "Task 2 (Dynamic Controls)")]
    public void DynamicControlsTest()
    {

    }
}