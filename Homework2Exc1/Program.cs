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

            // Расскомментировать, чтобы посмотреть созданный массив
            //foreach (int i in array)
            //{
            //    Console.Write(i + "\t");
            //}

            Console.WriteLine("Введите число:");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // Проверяем элементы массива и выводим сообщение
            Console.WriteLine($"Число '{userNumber}' " + (array.Contains(userNumber) ? "содержится" : "не содержится") + " в массиве");

        }
    }
}