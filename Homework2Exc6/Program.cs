/*
Задание 6
Создайте массив и заполните массив.
Выведите массив на экран в строку.
Замените каждый элемент с нечётным индексом на ноль.
Снова выведете массив на экран на отдельной строке.
*/

namespace Homework2Exc6
{
    public class Program
    {
        static void Main()
        {
            Random rnd = new();
            int arrayLength = rnd.Next(10, 20); // произвольная длина массива в промежутке от 10 до 20

            int[] firstArray = new int[arrayLength], secondArray = new int[arrayLength];

            // первый массив
            for (int i = 0; i < arrayLength; i++)
            {
                firstArray[i] = rnd.Next(101); // инициализируем элементы массива числами от 0 до 100
            }
            foreach (int i in firstArray)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();

            // второй массив
            for (int i = 0; i < arrayLength; i++)
            {
                // нечётные элементы инициализируем нулями, остальные значениями первого массива
                if (i % 2 != 0)
                {
                    secondArray[i] = 0;
                }
                else
                {
                    secondArray[i] = firstArray[i];
                }
            }
            foreach (int i in secondArray)
            {
                Console.Write(i + "\t");
            }
        }
    }
}