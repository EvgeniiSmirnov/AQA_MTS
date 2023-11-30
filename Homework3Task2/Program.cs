﻿/*
Задание 2
Используя метод вывода значения в консоль, выполните конкатенацию слов и выведите на экран следующую фразу:
Welcome to the TMS lessons.
Каждое слово должно быть записано отдельно и взято в кавычки, например "Welcome". Не забывайте о пробелах после каждого слова
*/

namespace Homework3Task2
{
    public class Program
    {
        static void Main()
        {
            {
                string str = "Welcome to the TMS lessons";

                //Используя разделитель пробела сплитим на массив строк, и джойним обратно в строку обвешивая кавычками
                Console.WriteLine($"\"{string.Join("\" \"", str.Split(" "))}\"");
            }
        }
    }
}