/*Задание 1:
Для приложения объявить тип делегата, который ссылается на метод.
Требования к сигнатуре метода следующие:
- метод не имеет входных параметров;
- метод возвращает int значение.
Реализовать вызов метода с помощью делегата. Метод возвращает случайное значение от 0 до 10.
*/

class Program
{
    // объявляем делегат
    private delegate int Number();

    static void Main()
    {
        // инициализируем делегат
        Number number = GetRandomNumber;

        // реализуем метод с помощью делегата
        Console.WriteLine(number());
    }

    /// <summary>
    /// Метод возвращает случайное значение от 0 до 10
    /// </summary>
    /// <returns></returns>
    private static int GetRandomNumber()
    {
        return new Random().Next(10);
    }
}