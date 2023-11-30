/*
Задание 4
Дана строка: “Плохой день.”
Необходимо с помощью метода substring удалить слово "плохой".
После чего необходимо используя команду insert создать строку со значением: Хороший день!!!!!!!!!.
Заменить последний "!" на "?"
*/

namespace Homework3Task4
{
    public class Program
    {
        static void Main()
        {
            {
                // в нижний регистр, затем замена плохой на Хороший
                string newStr = "Плохой день.".ToLower().Substring("плохой".Length).Insert(0, "Хороший");

                // убираем точку в конце и добавляем воскл знаки
                newStr = newStr.Insert(newStr.Length, "!!!!!!!!!").Remove(newStr.Length - 1, 1);

                // убираем ! в конце и добавляем ?
                newStr = newStr.Insert(newStr.Length, "?").Remove(newStr.Length - 1, 1);

                // выводим итоговый текст
                Console.WriteLine(newStr);
            }
        }
    }
}