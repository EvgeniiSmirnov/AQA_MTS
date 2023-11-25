/*
Задание 12
Создайте двумерный массив целых чисел. Отсортируйте элементы в строках
двумерного массива по возрастанию.
*/

namespace Homework2Exc12
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
            for (int i = 0; i < arraySize; i++)
            {
                for (int j = 0; j < arraySize; j++)
                {
                    array[i, j] = rnd.Next(10);         // инициализируем случайными числами
                    Console.Write(array[i, j] + "  ");  // выводим массив в консоль
                }
                Console.WriteLine();
            }

            // сортировка
            for (int i = 0; i < arraySize; i++)
            {
                for (int j = 0; j < arraySize; j++)
                {
                    for (int t = 0; t < arraySize - 1 - j; t++)
                    {
                        if (array[i, t] > array[i, t + 1])
                        {
                            int tmp = array[i, t];
                            array[i, t] = array[i, t + 1];
                            array[i, t + 1] = tmp;

                        }
                    }
                }
            }
            Console.WriteLine();

            // выводим новый массив в консоль
            Console.WriteLine("Массив после сортировки: ");
            for (int i = 0; i < arraySize; i++)
            {
                for (int j = 0; j < arraySize; j++)
                {
                    Console.Write(array[i, j] + "  ");  // выводим массив в консоль
                }
                Console.WriteLine();
            }
        }
    }
}