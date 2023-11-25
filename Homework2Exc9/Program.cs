/*
Задание 9
Умножение двух матриц
Создайте два массива целых чисел размером 3х3 (две матрицы).
Напишите программу для умножения двух матриц.
Первый массив: {{1,0,0,0},{0,1,0,0},{0,0,0,0}}
Второй массив: {{1,2,3},{1,1,1},{0,0,0},{2,1,0}}
Ожидаемый результат: 1 2 3 1 1 1 0 0 0
*/

namespace Homework2Exc9
{
    public class Program
    {
        static void Main()
        {
            int[,,] firstArray = new int[3, 4, 1] {
                    { {1}, {0}, {0}, {0} },
                    { {0}, {1}, {0}, {0} },
                    { {0}, {0}, {0}, {0} }
                },
            secondArray = new int[4, 3, 1] {
                    { {1}, {2}, {3} },
                    { {1}, {1}, {1} },
                    { {0}, {0}, {0} },
                    { {2}, {1}, {0} }
                },
             thirdArray = new int[3, 3, 1] {
                    { {1}, {2}, {3} },
                    { {4}, {5}, {6} },
                    { {7}, {8}, {9} },
                };

            PrintMatrix(firstArray);
            PrintMatrix(secondArray);
            PrintMatrix(thirdArray);
        }
        // метод для вывода элементов матрицы в консоль
        static void PrintMatrix(int[,,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++) // GetLength(0) - количество строк
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // GetLength(1) - количество столбцов
                {
                    Console.Write(matrix[i, j, 0] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}