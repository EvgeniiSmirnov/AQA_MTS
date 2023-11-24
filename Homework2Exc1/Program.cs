/*
Задание 1.
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
            // Создаём массив
            int[] array = new int[10];
            Random rnd = new();
            for (int i = 0; i < 10; i++)
            {
                array[i] = rnd.Next(51); //помещаем в массив случайное число от 0 до 50
            }

            // В услувии задачи не трубуется выводить изначальный массив, но вывожу для наглядности
            foreach (int i in array)
            {
                Console.Write(i + " ");

            }

            // Запрашиваем число из консоли
            Console.WriteLine("\nВведите число:");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // Проверяем элементы массива и выводим сообщение
            Console.WriteLine($"Число '{userNumber}' " + (array.Contains(userNumber) ? "содержится" : "не содержится") + " в массиве");

        }
    }
}