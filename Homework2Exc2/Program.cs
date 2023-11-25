/*
Задание 2
Создайте массив целых чисел. Удалите все вхождения заданного числа из массива.
Пусть число задается с консоли. Если такого числа нет - выведите сообщения об этом.
В результате должен быть новый массив без указанного числа.
*/

namespace Homework2Exc2
{
    public class Program
    {
        static void Main()
        {
            Random rnd = new();

            // Создаём массив
            int[] array = new int[20];
            for (int i = 0; i < 20; i++)
            {
                array[i] = rnd.Next(51); // инициализируем элементы массива числами от 0 до 50
            }

            // выводим массив в консоль для наглядности
            PrintArray(array);

            // Запрашиваем число из консоли
            Console.WriteLine("\nВведите число:");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // Проверяем элементы массива и выводим сообщение
            if (array.Contains(userNumber)) // условие, что введённое число есть в массиве
            {
                bool isUserNumber(int n)
                {
                    return n != userNumber;
                }

                array = Array.FindAll(array, isUserNumber).ToArray();
                PrintArray(array);
            }
            else // если числа нет, то выводим об этом сообщение
            {
                Console.Write($"Число '{userNumber}' не содержится в массиве");
            }
        }
        // Выводим массив в консоль
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