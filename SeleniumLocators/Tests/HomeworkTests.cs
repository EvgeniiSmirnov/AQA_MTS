/*Задание 4: Добавить тест для страницы Frames
Открыть iFrame
Проверить, что текст внутри параграфа равен “Your content goes here.”
*/

using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Reflection;

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
        var fileName = "123testFile.jpeg";

        // переходим на страницу File Upload по линкклику 
        WaitsHelper.WaitForVisibilityLocatedBy(By.LinkText("File Upload")).Click();

        // ждём кнопку выбора файла, кликаем по ней и указываем путь к файлу внутри проекта  
        WaitsHelper.WaitForExists(By.Id("file-upload")).
            SendKeys(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
            "Resources", fileName));

        // жмём кнопку Upload        
        WaitsHelper.WaitForExists(By.Id("file-submit")).Submit();

        // проверяем, что файл загружем
        Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("uploaded-files")).Text, Is.EqualTo(fileName));
    }

    [Test(Description = "Task 4 (Frames)")]
    public void FramesTest()
    {
        // переходим на страницу Frames по линкклику 
        WaitsHelper.WaitForVisibilityLocatedBy(By.LinkText("Frames")).Click();
        // переходим на страницу iFrame по линкклику 
        WaitsHelper.WaitForVisibilityLocatedBy(By.LinkText("iFrame")).Click();

        // переходим по дому в нужный фрейм и проверяем текст внутри Р
        Driver.SwitchTo().Frame(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("mce_0_ifr")));
        Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.XPath("//*[@id='tinymce']/p")).Text, Is.EqualTo("Your content goes here."));
    }
}