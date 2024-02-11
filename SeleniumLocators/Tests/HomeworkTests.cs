/*Задание 3: Добавить тест для страницы File Upload
Загрузить файл
Проверить, что имя файла на странице совпадает с именем загруженного файла

*/

using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SeleniumAdvanced.Tests;

class HomeworkTests : BaseTest
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
        // переходим на страницу Context Menu по линкклику 
        WaitsHelper.WaitForVisibilityLocatedBy(By.LinkText("Dynamic Controls")).Click();

        var checkBox = WaitsHelper.WaitForVisibilityLocatedBy(By.CssSelector("input[type='checkbox']"));
        var input = WaitsHelper.WaitForVisibilityLocatedBy(By.CssSelector("input[type='text']"));

        Assert.Multiple(() =>
        {
            // клик кнопку Remove
            WaitsHelper.WaitForVisibilityLocatedBy(By.XPath("//*[@onclick='swapCheckbox()' and text()='Remove']")).Click();
            // проверяем появление надписи It's gone!
            Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("message")).Text, Is.EqualTo("It's gone!"));
            // проверяем что чекбокс не виден
            Assert.That(WaitsHelper.WaitForElementInvisible(checkBox));
            // проверяем что input disabled
            Assert.That(input.Enabled, Is.False);
            // клик кнопку Enable
            WaitsHelper.WaitForVisibilityLocatedBy(By.XPath("//*[@onclick='swapInput()' and text()='Enable']")).Click();
            // проверяем появление надписи It's gone!
            Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("message")).Text, Is.EqualTo("It's enabled!"));
            // проверяем что input enabled
            Assert.That(input.Enabled);
        });
    }

    [Test(Description = "Task 3 (File Upload)")]
    public void FileUploadTest()
    {

    }
}