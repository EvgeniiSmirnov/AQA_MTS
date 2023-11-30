/*Задание 3
Дана строка: “teamwithsomeofexcersicesabcwanttomakeitbetter.”
Необходимо найти в данной строке "abc",
записав всё что до этих символов в первую переменную, а также всё, что после них во вторую.
Результат вывести в консоль.
*/

namespace Homework3Exc2
{
    public class Program
    {
        static void Main()
        {
            {
                string str = "teamwithsomeofexcersicesabcwanttomakeitbetter.", firstVar, secondVar;
                
                string[] newStr = str.Split("abc");

                //инициализируем переменные
                firstVar = newStr[0];
                secondVar = newStr[1];

                //выводим результат в консоль
                Console.WriteLine($"Первая переменная: {firstVar}\nвторая переменная: {secondVar}");
            }
        }
    }
}