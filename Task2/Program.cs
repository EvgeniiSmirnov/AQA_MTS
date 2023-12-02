/*
Задание 2
Создать класс CreditCard c полями 1 номер счета, 2 текущая сумма на счету.

Добавьте методы: 
который позволяет зачислять сумму на кредитную карту;
который позволяет снимать некоторую сумму с карты;
который выводит текущую информацию о карточке.

Напишите программу, которая создает три объекта класса CreditCard у которых заданы номер счета и начальная сумма.

Тестовый сценарий для проверки:
Положите деньги на первые две карточки и снимите с третьей.
Выведите на экран текущее состояние всех трех карточек.
*/
using Task2;
public class Programm
{
    static void Main()
    {
        CreditCard creditCard1 = new("40817810123456111", 100);
        CreditCard creditCard2 = new("40817810123456222", 200);
        CreditCard creditCard3 = new("40817810123456333", 300);

        // проверка функционала
        creditCard1.AddAmount(100);
        creditCard2.AddAmount(100);
        creditCard3.TakeAmount(100);

        CreditCard[] creditCards = { creditCard1, creditCard2, creditCard3 };
        foreach (var creditCard in creditCards)
        {
            creditCard.GetInfo();
            Console.WriteLine();
        }
    }
}