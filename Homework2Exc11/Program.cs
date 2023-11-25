/*
Задание 11
Создайте двумерный массив. Выведите на консоль диагонали массива.
*/

namespace Homework2Exc11
{
    public class Program
    {
        static void Main()
        {
            Random rnd = new();

            // создаём двумерный массив
            int arraySize = rnd.Next(10, 20);
            int[,] array = new int[arraySize, arraySize];

            // инициализируем случайными числами
            for (int i = 0; i < arraySize; i++)
            {
                for (int j = 0; j < arraySize; j++)
                {
                    array[i, j] = rnd.Next(10);
                }
            }

            // выводим массив в консоль
            for (int i = 0; i < array.GetLength(0); i++) // GetLength(0) - количество строк
            {
                for (int j = 0; j < array.GetLength(1); j++) // GetLength(1) - количество столбцов
                {
                    Console.Write(array[i, j] + "  ");
                }
                Console.WriteLine();
            }

            // ищем диагонали
            string firstDiagonal = "", secondDiagonal = "";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j)
                        firstDiagonal += array[i, j] + " ";
                    if (i + j == arraySize - 1)
                        secondDiagonal += array[i, j] + " ";
                }
            }

            Console.WriteLine($"Первая (начало в 00) диагональ: {firstDiagonal}\nВторая диагональ: {secondDiagonal}");
        }
    }
}