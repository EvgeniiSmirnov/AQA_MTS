/*
Задание 6
Дана строка (максимальная длина 100 символов), содержащая слова, разделенные пробелами или знаками табуляции.
Число слов в строке не превышает 20, а длина каждого слова не более 10 символов.
Упорядочить слова в строке по алфавиту.
*/

using System.Text.RegularExpressions;

namespace Homework3Task7
{
    public class Program
    {
        static void Main()
        {
            {
                string text = "1. Some      text  with  some test  words. 2.  There first test word";
                Console.WriteLine("Текст до изменений:\n" + text);

                string[] formatText = Regex.Replace(text, @"\s+", " ").Split(" ");

                bool flag = true;
                if (formatText.Length < 20)
                {
                    Console.WriteLine($"Число слов в строке не превышает 20. Число слов: {formatText.Length}");
                    foreach (string str in formatText)
                    {
                        if (str.Length > 10)
                        {
                            flag = true;
                            Console.WriteLine($"Длина слова {str} = {str.Length} более десяти символов.");
                            break;
                        }
                        else
                        {
                            flag = false;
                        }
                    }
                    if (!flag)
                    {
                        Array.Sort(formatText);
                        Console.WriteLine($"Длина каждго слова не превышает 10 символов");
                        Console.WriteLine("Текст после изменений:\n" + String.Join(" ", formatText));
                    }
                }
                else
                {
                    Console.WriteLine($"Число слов в строке превышает 20. Число слов: {formatText.Length}");
                }
            }
        }
    }
}