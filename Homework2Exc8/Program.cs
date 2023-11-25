/*
Задание 8
Реализуйте алгоритм сортировки пузырьком.
*/

namespace Homework2Exc7
{
    public class Program
    {
        static void Main()
        {
            Random rnd = new();
            int arrayLength = rnd.Next(10, 20); // произвольная длина массива в промежутке от 10 до 20
            int[] arrayToSort = new int[arrayLength];
            int tmp;

            // метод для вывода элементов массива в консоль
            void printArray(int[] array)
            {
                foreach (int i in array)
                {
                    Console.Write(i + "\t");
                }
                Console.WriteLine();
            }

            // инициализируем элементы массива числами от -50 до 50
            for (int i = 0; i < arrayLength; i++)
            {
                arrayToSort[i] = rnd.Next(-50, 50);
            }
            printArray(arrayToSort);

            // сортируем элементы (самый большой должен уйти в конец)
            for (int i = 0; i < arrayToSort.Length; i++)            // левые элементы 
                for (int j = i + 1; j < arrayToSort.Length; j++)    // правые
                    if (arrayToSort[i] > arrayToSort[j])            // если левый больше правого, то меняем их местами
                    {
                        tmp = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[j];
                        arrayToSort[j] = tmp;
                    }
            printArray(arrayToSort);
        }
    }
}