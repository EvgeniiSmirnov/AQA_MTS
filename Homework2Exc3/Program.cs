/*
Задание 3
Создайте и заполните массив случайным числами и выведете максимальное, минимальное и среднее значение.
Для генерации случайного числа используйте метод Random().
Пусть будет возможность создавать массив произвольного размера.
Пусть размер массива вводится с консоли.
*/

namespace Homework2Exc3
{
    public class Program
    {
        static void Main()
        {
            Random rnd = new();

            // Запрашиваем число из консоли
            Console.WriteLine("Введите число (размер массива):");
            int arrayLength = Convert.ToInt32(Console.ReadLine());

            // Создаём массив
            int[] array = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = rnd.Next(arrayLength * 10); // инициализируем элементы массива случайными числами
            }

            // Выводим массив в консоль
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // Выводим расчёты в консоль
            Console.WriteLine($"""
                Минимальное число в массиве: {array.Min()}
                Максимальное число в массиве: {array.Max()}
                Средний элемент в массиве: {array.Length / 2} 
                Среднее значение числа в массиве: {array.Sum() / arrayLength}
                """);// тут я не понял, нужен средний элемент, или среднее арифметическое, поэтому оба посчитал ヽ(°° )ノ
        }
    }
}