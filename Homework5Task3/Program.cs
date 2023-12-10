/*
Задание 3
Создать класс, со следующими свойствами:
сlass Bus: Пункт назначения, Номер, Время отправления, Число мест
Определить get, set методы для этих свойств.

Создать класс с main методом, в котором будет объявлен объект класса Bus. Вывести все данные (значения полей) объекта в консоль.

Определить иерархию классов в предметной области: Парк общественного траспорта.
Определить иерархию различных видов общественного транспорта (например, Trolleybus, Tramcar и т.д. на подобие класса Bus выше.)
Определить в суперклассе (например, сlass Transport) метод, возвращающий тип транспорта (Electric, Rail, и т.п.).
Переопределить этот метод в классах наследниках.

В классе с main методом создать массив объектов из различных видов транспорта.
Провести сортировку транспорта по количеству мест и вывести данные объектов в консоль.
Запросить у пользователя время отправления и/или пункт назначения. Найти в массиве объект, соответствующий заданным параметрам, и вывести его данные в консоль.
Запросить у пользователя время отправления. Вывести в консоль список транспорта, отправляющегося после заданного времени.

* Определить метод в суперклассе (e.g. Transport), который нельзя будет переопределить в классах наследниках и запретить это переопределение.
* Создать класс TransportService. Определить внутри класса TransportService метод printTransportType,
* который будет принимать объект типа Transport как параметр.
* Внутри метода printTransportType необходимо вызвать другой метод, возвращающий тип транспорта и вывести эту информацию на консоль.
* В main вызвать метод printTransportType несколько раз, передавая ему как параметр объекты классов наследников (Bus, Trolleybus и т.д.)
*/

using Homework5Task3;
using System.Globalization;

public class Programm
{
    static void Main()
    {

        Trolleybus trolleybus = new Trolleybus("Проспект Космонавтов", 12, new DateTime(2023, 12, 12, 12, 00, 00), 35);
        trolleybus.DestroyTransport();
        // объявлен объект класса Bus. Вывести все данные (значения полей) объекта в консоль.
        Transport bus = new Bus("Екатеринбург", 10, new DateTime(2023, 10, 10, 10, 00, 00), 25);
        bus.PrintTransportInfo();
        Console.WriteLine();

        // создать массив объектов из различных видов транспорта.
        Transport[] transports =
            {
                new Trolleybus("Проспект Космонавтов", 12, new DateTime(2023, 12, 12, 12, 00, 00), 35),
                new Tram("Парк Культуры", 11, new DateTime(2023, 11, 11, 11, 00, 00), 19),
                new Bus("Екатеринбург", 13, new DateTime(2023, 09, 09, 09, 00, 00), 44)
            };

        // Провести сортировку транспорта по количеству мест и вывести данные объектов в консоль
        {
            // вывод массива до сортировки
            foreach (Transport transport in transports) transport.PrintTransportInfo();
            Console.WriteLine();

            // сортировка по числу мест
            var sortedArray = transports.OrderBy(key => key.SeatNumber);

            // вывод массива после сортировки
            foreach (Transport transport in sortedArray) transport.PrintTransportInfo();
            Console.WriteLine();
        }

        // Запросить у пользователя время отправления и/или пункт назначения.
        // Найти в массиве объект, соответствующий заданным параметрам, и вывести его данные в консоль.
        Console.WriteLine("Введите пункт назначения:");
        string? requestDestination = Console.ReadLine();
        int counter = 0;
        foreach (Transport transport in transports)
        {
            if (transport.Destination == requestDestination)
            {
                Console.WriteLine("Найден транспорт:");
                transport.PrintTransportInfo();
            }
            else
            {
                counter++;
            }
            if (counter == 3) Console.WriteLine("Запрошиваемый пункт назначения не найден");
        }

        // Запросить у пользователя время отправления. Вывести в консоль список транспорта, отправляющегося после заданного времени.
        Console.WriteLine("Введите дату и время отправления в формате MM/dd/yyyy HH:mm:ss:");
        CultureInfo provider = new CultureInfo("en-US");
        try
        {
            DateTime requestTiming = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy HH:mm:ss", provider);
            Console.WriteLine(requestTiming);


            counter = 0;
            foreach (Transport transport in transports)
            {
                if (transport.DepartureTime > requestTiming)
                {
                    Console.WriteLine("Найден транспорт:");
                    transport.PrintTransportInfo();
                }
                else
                {
                    counter++;
                }
                if (counter == 3) Console.WriteLine("Не найдено транспорта с отправлением позже запршиваемой даты");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Ошибка ввода даты");
        }

        // Внутри метода printTransportType необходимо вызвать другой метод, возвращающий тип транспорта
        // и вывести эту информацию на консоль.
        // вызвать метод printTransportType несколько раз, передавая ему как параметр объекты классов наследников (Bus, Trolleybus и т.д.)
        TransportService service = new TransportService();
        foreach (Transport transport in transports)
        {
            service.PrintTransportService(transport);
        }
    }
}