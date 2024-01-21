/*Задание 4:
Представим, у вас есть система управления событиями, и вы хотите реализовать механизм подписки на эти события с использованием делегатов.
Требуется создать простой календарь с возможностью добавления событий и подписки на уведомления о предстоящих событиях.
Class Event должен содержать:
- string Title
- DateTime Date
- string Description

Тип делегата ссылается на методы со следующей сигнатурой:
- метод имеет входной параметр типа Event;
- метод не возвращает значение.
Основная программа добавляет несколько событий и затем уведомляет подписчиков о событии которое проходит сегодня.
*/

using Homework10Task4;

class Program
{
    static void Main()
    {
        Calendar calendar = new();
        // добавляем события в календарь
        calendar.AddEvent(new Event("ДР Макса", new DateTime(2024, 01, 05), "Поздравить"));
        calendar.AddEvent(new Event("Кот", DateTime.Now, "Покормить кота"));
        calendar.AddEvent(new Event("Аванс", new DateTime(2024, 03, 15), "Проверить баланс карты"));

        calendar.Notification += Event.PrintEventInfo; // Добавляем обработчик для события Notification 
        calendar.TodayEventNotification();
    }
}