/*Задание 1:
Реализовать класс Point, который определяет точку на координатной плоскости. В классе реализовать:
- внутренние поля x, y;
- конструктор с 2 параметрами;
- свойства доступа к внутренним полям класса;
- метод, выводящий значения внутренних полей класса.
*/

using Homework9Task1;
class Program
{
    public static void Main()
    {
        // создадим разнотипные объекты
        Point<int> pointInt = new(10, 20);
        Point<decimal> pointDecimal = new(30m, 40m);
        Point<string> pointString = new("50", "60");
        
        // проверка метода
        pointInt.Print();
        pointDecimal.Print();

        // проверка свойств
        Console.WriteLine($"({pointString.X}, {pointString.Y})");
        Console.WriteLine($"({pointInt.X=15}, {pointInt.Y=30})");
    }
}