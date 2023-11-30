/*
Задание 6
Дана строка (максимально 100 символов), содержащая слова, разделенные одним или несколькими пробелами, или знаками табуляции.
Заменить все знаки табуляции знаком пробела, удалить двойные пробелы из строки.
При реализации программы функции из библиотеки System.String не использовать.
*/

using System.Text.RegularExpressions;

namespace Homework3Task6
{
    public class Program
    {
        static void Main()
        {
            {
                string text = "1. Some      text  with  some test  words. 2.  There first test word";
                Console.WriteLine("Текст до изменений:\n" + text);

                string newText = Regex.Replace(text, @"\s+", " ");
                Console.WriteLine("Текст после изменений:\n" + newText);
            }
        }
    }
}