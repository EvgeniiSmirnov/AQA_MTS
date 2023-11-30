﻿/*
Задание 5
Написать программу со следующим функционалом:
На вход передать строку (будем считать, что это номер документа).
Номер документа имеет формат xxxx-yyy-xxxx-yyy-xyxy, где x — это число, а y — это буква.
- Вывести на экран в одну строку два первых блока по 4 цифры.
- Вывести на экран номер документа, но блоки из трех букв заменить на *** (каждая буква заменятся на *).
- Вывести на экран только одни буквы из номера документа в формате yyy/yyy/y/y в нижнем регистре.
- Вывести на экран буквы из номера документа в формате "Letters:yyy/yyy/y/y" в верхнем регистре (реализовать с помощьюкласса StringBuilder).
- Проверить содержит ли номер документа последовательность abc и вывети сообщение содержит или нет
(причем, abc и ABC считается одинаковой последовательностью).
- Проверить начинается ли номер документа с последовательности 555.
- Проверить заканчивается ли номер документа на последовательность 1a2b.
Все эти методы реализовать в отдельном классе в статических методах,
которые на вход (входным параметром) будут принимать вводимую на вход программы строку.
*/
using Methods;
using System.Text;
using System.Text.RegularExpressions;

namespace Homework3Task5
{
    public class Program
    {
        public static void Main()
        {
            string documentNumber = "0123-abc-4567-DEF-8g9h";

            TaskFiveMethods.PrintDigitBlocksByFourNumbers(documentNumber);
            TaskFiveMethods.PrintAsteriskModification(documentNumber);
            TaskFiveMethods.PrintOnlyLettersToLower(documentNumber);
            TaskFiveMethods.PrintOnlyLettersToUpper(documentNumber);
            TaskFiveMethods.PrintCheckABCResult(documentNumber);
            TaskFiveMethods.PrintCheck555Result(documentNumber);
            TaskFiveMethods.PrintCheck1a2bResult(documentNumber);
        }
    }
}