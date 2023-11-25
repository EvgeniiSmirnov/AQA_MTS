/*
Задание 9
Умножение двух матриц
Создайте два массива целых чисел размером 3х3 (две матрицы).
Напишите программу для умножения двух матриц.
*/

namespace Homework2Exc9
{
    public class Program
    {
        static void Main()
        {
            // инициализируем первую и вторую матрицы, третью только объявлем
            int[,] firstMatrix = new int[3, 3] {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                    { 7, 8, 9 },
                },
            secondMatrix = new int[3, 3] { // для простоты счёта вторая матрица на манер единичной
                                           // и при умножении на неё все значения первой должны удваиваться 
                    { 2, 0, 0 },
                    { 0, 2, 0 },
                    { 0, 0, 2 },
                },
            result = new int[3, 3];

            Console.WriteLine("Первая матрица: ");
            PrintMatrix(firstMatrix);
            Console.WriteLine("Вторая матрица: ");
            PrintMatrix(secondMatrix);

            // цикл для перемножения элементов
            for (int i = 0; i < 3; i++) // строка
            {
                for (int j = 0; j < 3; j++) // столбец
                {
                    for (int u = 0; u < 3; u++) // 'втуренний' элемент
                    {
                        result[i, j] += firstMatrix[i, u] * secondMatrix[u, j];
                    }
                }
            }
            Console.WriteLine("Результат умножения матриц: ");
            PrintMatrix(result);
        }
        // метод для вывода элементов матрицы в консоль
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++) // GetLength(0) - количество строк
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // GetLength(1) - количество столбцов
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}