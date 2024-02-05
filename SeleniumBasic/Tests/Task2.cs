/*Задание 2:
Написать тест на проверку расчетов “Калькулятор ламината” (https://home-ex.ru/calculation/ ).
В рамках теста проверить рассчитанные результаты
*/
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumBasic.Tests;

class Task2 : BaseTest
{
    [Test]
    public void LaminateCalculationTest()
    {
        Driver.Navigate().GoToUrl("https://home-ex.ru/calculation/");

        // элементы калькулятора
        IWebElement lengthRoomField = Driver.FindElement(By.Id("ln_room_id")), // Длина комнаты
        widthRoomField = Driver.FindElement(By.Id("wd_room_id")),       // Ширина комнаты
        lengthLaminateField = Driver.FindElement(By.Id("ln_lam_id")),   // Длина плашки
        widthLaminateField = Driver.FindElement(By.Id("wd_lam_id")),    // Ширина плашки
        quantityByPackField = Driver.FindElement(By.Id("n_packing")),   // Число плашек в упаковке
        areaPackField = Driver.FindElement(By.Id("area")),              // Площадь упаковки
        radioButton45 = Driver.FindElement(By.Id("direction-laminate-id2")),        // Радио-батон Укладки по диагонали 45
        minSegmentLenthField = Driver.FindElement(By.Id("min_length_segment_id")),  // Минимальная длина обрезка
        indentWallsField = Driver.FindElement(By.Id("indent_walls_id")),            // Отступ от стен
        calculateButton = Driver.FindElement(By.Id("btn_calculate"));               // Кнопка Рассчитать

        // удаляем дефолтные значения и вводим свои
        lengthRoomField.Clear();
        lengthRoomField.SendKeys("350");

        widthRoomField.Clear();
        widthRoomField.SendKeys("300");

        lengthLaminateField.Clear();
        lengthLaminateField.SendKeys("1500");

        widthLaminateField.Clear();
        widthLaminateField.SendKeys("300");

        quantityByPackField.Clear();
        quantityByPackField.SendKeys("15");

        areaPackField.SendKeys("6.75");

        radioButton45.Click(); // выбираем значение 45

        new SelectElement(Driver.FindElement(By.Id("laying_method_laminate"))).SelectByValue("2"); // выбираем значение с использование отрезанного элемента

        minSegmentLenthField.SendKeys(Keys.Backspace);
        minSegmentLenthField.SendKeys("300");

        indentWallsField.SendKeys(Keys.Backspace);
        indentWallsField.SendKeys("15");

        // кликаем кнопку рассчитать и ждём рассчёт
        calculateButton.Click();
        Thread.Sleep(5000);

        // проверяем данные рассчёта
        string result = Driver.FindElement(By.ClassName("calc-result")).Text;
        Assert.That(result.Contains("Требуемое количество плашек ламината: 135") && result.Contains("Количество упаковок ламината: 9"));
    }
}