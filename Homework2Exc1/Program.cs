/*
Задание 1
Создайте массив целых чисел.
Напишете программу, которая выводит сообщение о том, входит ли заданное число в массив или нет.
Пусть число для поиска задается с консоли.
*/

namespace Homework2Exc1
{
    public class Program
    {
        static void Main()
        {
            Random rnd = new();
            // создаём массив
            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                array[i] = rnd.Next(51); // инициализируем элементы массива числами от 0 до 50
            }

            // выводим элементы массива в консоль, но вывожу для наглядности
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

            // запрашиваем число из консоли
            Console.WriteLine("\nВведите число:");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // проверяем элементы массива и выводим сообщение
            Console.WriteLine($"Число '{userNumber}' " + (array.Contains(userNumber) ? "содержится" : "не содержится") + " в массиве");
        }
    }
}