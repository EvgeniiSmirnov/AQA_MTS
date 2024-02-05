/*Задание 2:
Написать тест на проверку расчетов “Калькулятор ламината” (https://home-ex.ru/calculation/ ).
В рамках теста проверить рассчитанные результаты
*/
namespace SeleniumBasic.Tests;

class Task2 : BaseTest
{
    [Test]
    public void LaminateCalculationTest()
    {
        Driver.Navigate().GoToUrl("https://home-ex.ru/calculation/");
    }
}