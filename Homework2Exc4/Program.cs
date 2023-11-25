/*
Задание 4
Создайте 2 массива из 5 чисел.
Выведите массивы на консоль в двух отдельных строках.
Посчитайте среднее арифметическое элементов каждого массива и сообщите,
для какого из массивов это значение оказалось больше (либо сообщите, что их средние арифметические равны).
*/

namespace Homework2Exc4
{
    public class Program
    {
        static void Main()
        {
            Random rnd = new();

            // Создаём массивы
            int[] firstArray = new int[5], secondArray = new int[5];
            for (int i = 0; i < 5; i++)
            {
                firstArray[i] = rnd.Next(101); // инициализируем элементы массива числами от 0 до 100
                secondArray[i] = rnd.Next(101);
            }

            PrintArray(firstArray);
            PrintArray(secondArray);

            // Считаем и сравниваем среднее арифметеческое элементов массивов
            if ((firstArray.Sum() / 5) > (secondArray.Sum() / 5))
            {
                Console.WriteLine($"Среднее арифметическое первого массива больше чем второго" +
                    $" ({(firstArray.Sum() / 5)} > {(secondArray.Sum() / 5)})");
            }
            else if ((firstArray.Sum() / 5) < (secondArray.Sum() / 5))
            {
                Console.WriteLine($"Среднее арифметическое второго массива больше чем первого" +
                    $" ({(firstArray.Sum() / 5)} < {(secondArray.Sum() / 5)})");
            }
            else
            {
                Console.WriteLine($"Средние арифметические у массивов равны " +
                    $" ({(firstArray.Sum() / 5)} = {(secondArray.Sum() / 5)})");
            }
        }
        // Выводим массивы в консоль
        static void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
        }
    }
}