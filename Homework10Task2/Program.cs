/*Задание 2:
Для приложения объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:
- метод получает входным параметром переменную типа double;
- метод возвращает значение типа double, которое есть результатом вычисления в соответствии с условием задачи.
Реализовать вызов трех методов с помощью делегата, которые получают радиус R в качестве входного параметра и вычисляют:
- длину окружности по формуле D = 2 · π · R;
- площадь круга по формуле S = π · R2;
- объем шара. Формула V = 4/3 · π · R3.
Методы должны быть представлены в отдельном классе как нестатические (без ключевого слова static).
Желательно, чтобы класс был объявлен в отдельном модуле (файле).
*/

using Homework10Task2;

class Program
{
    public delegate double Calculation(double radius);

    public static void Main()
    {

        GeometricFormulas figure = new();
        double radius = 11.1;

        Calculation circleLength = figure.GetCircleLength;
        Calculation circleSquare = figure.GetCircleSquare;
        Calculation sphereVolume = figure.GetSphereVolume;

        Console.WriteLine($"Длина окружности: {circleLength(radius):f2}");
        Console.WriteLine($"Площадь круга: {circleSquare(radius):f2}");
        Console.WriteLine($"Объём шара: {sphereVolume(radius):f2}");
    }
}