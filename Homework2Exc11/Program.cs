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

            // массируем ヽ(°° )ノ массив 
            string firstDiagonal = "", secondDiagonal = "";
            for (int i = 0; i < arraySize; i++)
            {
                for (int j = 0; j < arraySize; j++)
                {
                    array[i, j] = rnd.Next(10);         // инициализируем случайными числами
                    Console.Write(array[i, j] + "  ");  // выводим массив в консоль
                    // первая диагональ
                    if (i == j)
                        firstDiagonal += array[i, j] + " ";
                    // вторая диагональ
                    if (i + j == arraySize - 1)
                        secondDiagonal += array[i, j] + " ";
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Первая (начало в 00) диагональ: {firstDiagonal}\nВторая диагональ: {secondDiagonal}");
        }
    }
}