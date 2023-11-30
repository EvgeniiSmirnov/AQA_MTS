/*
Задание 1
Заменить в строке все вхождения 'test' на 'testing'.
Удалить из текста все символы, являющиеся цифрами.
*/

namespace Homework3Task1
{
    public class Program
    {
        static void Main()
        {
            {
                string text = "1. Some text with some test words. 2. There first test word or what? 999. Something here too.";
                Console.WriteLine("Текст до изменений:\n" + text);

                text = text.Replace("test", "testing");

                foreach (char s in text)
                {
                    if (Char.IsDigit(s))
                        text = text.Replace(s, new char());
                }

                Console.WriteLine("Текст после изменений:\n" + text);
            }
        }
    }
}