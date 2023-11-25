/*
Задание 5
Создайте массив из n случайных целых чисел и выведите его на экран.
Размер массива пусть задается с консоли и размер массива может быть больше 5 и меньше или равно 10.
Если n не удовлетворяет условию - выведите сообщение об этом.
Если пользователь ввёл не подходящее число, то программа должна просить пользователя повторить ввод.
Создайте второй массив только из чётных элементов первого массива, если они там есть, и вывести его на экран.
*/

namespace Homework2Exc5
{
    public class Program
    {
        static void Main()
        {
            Random rnd = new();

            // Запрашиваем размерность массива из консоли
            Console.WriteLine("Введите размер массива (5 < n <= 10)");
            int arrayLength = Convert.ToInt32(Console.ReadLine());

            bool flag;
            do
            {
                // Проверяем, что размер массива соответствует условию (5 < n <= 10)
                if (5 < arrayLength && arrayLength <= 10)
                {
                    Console.WriteLine($"Размер массива '{arrayLength}' соответствует условию");
                    flag = true;
                }
                else
                {
                    Console.WriteLine($"Размер массива '{arrayLength}' не соответствует условию, задайте размер повторно");
                    flag = false;
                    arrayLength = Convert.ToInt32(Console.ReadLine());
                }
            } while (!flag);


            int[] firstArray = new int[arrayLength], secondArray = new int[arrayLength];

            // Созадаём первый массив
            for (int i = 0; i < arrayLength; i++)
            {
                firstArray[i] = rnd.Next(101); // инициализируем элементы массива числами от 0 до 100
            }
            foreach (int i in firstArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // Проверяем элементы первого массива на чётность
            bool isEven(int n)
            {
                return n % 2 == 0;

            }

            // добавляем чётные элементы во второй массив
            secondArray = Array.FindAll(firstArray, isEven).ToArray();

            // проверяем второй массив на пустоту
            if (secondArray == null || secondArray.Length == 0)
            {
                Console.WriteLine("Второй массив пуст");
            }
            else
            {
                foreach (int i in secondArray)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}