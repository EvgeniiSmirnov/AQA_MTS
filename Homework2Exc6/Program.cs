/*
Задание 6
Создайте массив и заполните массив.
Выведите массив на экран в строку.
Замените каждый элемент с нечётным индексом на ноль.
Снова выведете массив на экран на отдельной строке.
*/

namespace Homework2Exc6
{
    public class Program
    {
        static void Main()
        {
            Random rnd = new();

            int arrayLength = rnd.Next(10, 20); // произвольная длина массива в промежутке от 10 до 20
            int[] firstArray = new int[arrayLength];

            // инициализируем элементы массива числами от 0 до 100
            for (int i = 0; i < arrayLength; i++)
            {
                firstArray[i] = rnd.Next(101);
            }
            PrintArray(firstArray);

            // нечётные индексы инициализируем нулями
            for (int i = 1; i < arrayLength; i += 2)
            {
                firstArray[i] = 0;
            }
            PrintArray(firstArray);
        }
        // метод для вывода элементов массива в консоль
        static void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
        }
    }
}