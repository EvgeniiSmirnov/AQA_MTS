/*Задание 2:
Напишите обобщенный класс, который может хранить в массиве объекты любого типа.
Также, данный класс должен иметь методы для добавления данных в массив, удаления из массива,
получения элемента из массива по индексу и метод, возвращающий длину массива.

Для упрощения работы можно пересоздавать массив при каждой операции добавления и удаления
*/

using Homework9Task2;

class Program
{
    static void Main()
    {
        // создадим разнотипные объекты
        Generic<int> arrayInt = new(5);
        Generic<string> arrayString = new(5);

        // инициализируем обекты
        {
            for (int i = 0; i < 5; i++)
            {
                arrayInt.GenericArray[i] = new Random().Next(100);
            }

            for (int i = 0; i < 5; i++)
            {
                arrayString.GenericArray[i] = "строка" + new Random().Next(10);
            }
        }

        // используем методы обобщенного класса
        Console.WriteLine("Массив c интами:");
        Check(arrayInt, 777);
        Console.WriteLine(arrayInt.GetElementByIndex(0));

        Console.WriteLine("Массив со строками:");
        Check(arrayString, "ПРОВЕРКА");
        Console.WriteLine(arrayString.GetElementByIndex(0));

        // вспомогательный метод для однотипных проверок
        static void Check<T>(Generic<T> array, T value)
        {
            // выведем элементы массива
            array.Print();

            // добавим элемент и выведем элементы массива
            array.Add(value);
            array.Print();

            // удалим элемент и выведем элементы массива
            array.Delete(value);
            array.Print();

            // выведем длину массива
            Console.WriteLine($"Длина массива: {array.GetArrayLenth()}");
        }
    }
}