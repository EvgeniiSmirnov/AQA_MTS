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

            // метод для вывода элементов массива в консоль
            void printArray(string[] array)
            {
                foreach (string i in array)
                {
                    Console.Write(i + "\t");
                }
                Console.WriteLine();
            }

            printArray(nameArray);
            Array.Sort(nameArray); // сортируем элементы
            printArray(nameArray);
        }
    }
}