/*
Задание 7
Создайте массив строк. Заполните его произвольными именами людей.
Отсортируйте массив. Результат выведите на консоль.
*/

namespace Homework2Exc7
{
    public class Program
    {
        static void Main()
        {
            string[] nameArray = { "Sam", "Bob", "Maria", "Kelly", "Ann", "Adam" };

            PrintArray(nameArray);
            Array.Sort(nameArray); // сортируем элементы
            PrintArray(nameArray);
        }

        // метод для вывода элементов массива в консоль
        static void PrintArray(string[] array)
        {
            foreach (string i in array)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
        }
    }
}