/*Задание 1:
Закончить тест на проверку СКФ (https://bymed.top/calc/%D1%81%D0%BA%D1%84-2148 ).
В рамках теста проверить рассчитанные результаты
*/
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumBasic.Tests;

class Task1 : BaseTest
{
    [Test]
    public void ValidateSKF()
    {
        Driver.Navigate().GoToUrl("https://bymed.top/calc/%D1%81%D0%BA%D1%84-2148");
        Driver.SwitchTo().Frame(Driver.FindElement(By.XPath("//iframe[@src]")));

        // заполняем калькулятор
        Driver.FindElement(By.Id("age")).SendKeys("33"); // возраст
        new SelectElement(Driver.FindElement(By.Id("sex"))).SelectByValue("M"); // пол, выбираем через селект и передаём значение
        Driver.FindElement(By.Id("cr")).SendKeys("111"); // креатинин
        new SelectElement(Driver.FindElement(By.Id("cr-size"))).SelectByIndex(0); // единицы измерения креатинина
        new SelectElement(Driver.FindElement(By.Id("race"))).SelectByText("Другая"); // раса
        Driver.FindElement(By.Id("mass")).SendKeys("80"); // вес
        Driver.FindElement(By.Id("grow")).SendKeys("182"); // рост

        // кликаем кнопку рассчитать
        Driver.FindElement(By.XPath("//button[text()='Рассчитать']")).Click();

        Thread.Sleep(5000);

        Assert.Multiple(() =>
        {
            //MDRD
            Assert.That(Driver.FindElement(By.Id("mdrd_res")).Text, Is.EqualTo("66.17"));
            Assert.That(Driver.FindElement(By.TagName("i")).Text, Is.EqualTo("мл/мин/1.73м2"));
            Assert.That(Driver.FindElement(By.ClassName("diagnosis")).Text, Is.EqualTo("Незначительно сниженный уровень СКФ (C2)"));

            //CKD-EPI
            Assert.That(Driver.FindElement(By.Id("ckd_epi_res")).Text, Is.EqualTo("74.77"));

            //Формула Кокрофта-Голта
            Assert.That(Driver.FindElement(By.Id("cge")).Text, Is.EqualTo("94.68 мл/мин"));

            //Формула Шварца
            Assert.That(!Driver.FindElement(By.Id("schwartz")).Displayed);
        });
    }
}