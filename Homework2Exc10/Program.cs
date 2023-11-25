/*
Задание 10
Создайте двумерный массив целых чисел.
Выведите на консоль сумму всех элементов массива.
*/

namespace Homework2Exc10
{
    public class Program
    {
        static void Main()
        {
            Random rnd = new();

            // создаём двумерный массив
            int[,] array = new int[3, 3];
            // инициализируем случайными числами
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = rnd.Next(51);
                }
            }

            // выводим массив в консоль
            for (int i = 0; i < array.GetLength(0); i++) // GetLength(0) - количество строк
            {
                for (int j = 0; j < array.GetLength(1); j++) // GetLength(1) - количество столбцов
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // считаем и выводим сумму
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum += array[i, j];
                }
            }
            Console.WriteLine($"\nСумма элементов массива: {sum}");
        }
    }
}