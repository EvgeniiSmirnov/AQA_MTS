using System.Text;
using System.Text.RegularExpressions;

namespace Methods
{
    public static class TaskFiveMethods
    {
        public static void PrintDigitBlocksByFourNumbers(string documentNumber)
        {
            {
                // Вывести на экран в одну строку два первых блока по 4 цифры
                MatchCollection mc = Regex.Matches(documentNumber, @"\d{4}");
                string result = "";

                foreach (Match match in mc)
                {
                    result += match.Value + " ";
                }

                Console.WriteLine(result);
            }
        }
        public static void PrintAsteriskModification(string documentNumber)
        {
            // Вывести на экран номер документа, но блоки из трех букв заменить на *** (каждая буква заменятся на *)
            string result = new Regex(@"[a-zA-Z]{3}").Replace(documentNumber, "***");

            Console.WriteLine(result);
        }

        public static void PrintOnlyLettersToLower(string documentNumber)

        {
            // Вывести на экран только одни буквы из номера документа в формате yyy/yyy/y/y в нижнем регистре.
            MatchCollection mc = Regex.Matches(documentNumber, @"[a-zA-Z]{3}|(?:[a-z])");
            int count = 0;

            foreach (Match match in mc)
            {
                string result3 = match.Groups[0].Value.ToLower();
                count++;

                Console.Write(result3);

                if (mc.Count != count)
                {
                    Console.Write("/");
                }
            }
            Console.WriteLine();
        }
        public static void PrintOnlyLettersToUpper(string documentNumber)
        {
            // Вывести на экран буквы из номера документа в формате "Letters:yyy/yyy/y/y" в верхнем регистре
            // (реализовать с помощью класса StringBuilder)
            StringBuilder sb = new();

            foreach (Match match in Regex.Matches(documentNumber, @"[a-zA-Z]{3}|(?:[a-z])"))
            {
                sb.Append(match.Value.ToUpper());
            }

            sb.Insert(3, "/").Insert(7, "/").Insert(9, "/");

            Console.WriteLine("Letters:" + sb);
        }

        public static void PrintCheckABCResult(string documentNumber)
        {
            // Проверить содержит ли номер документа последовательность abc и вывети сообщение содержит или нет
            // (причем, abc и ABC считается одинаковой последовательностью).
            if (documentNumber.Contains("abc") || documentNumber.Contains("ABC"))
            {
                Console.WriteLine("Последовательность содержит");
            }
            else
            {
                Console.WriteLine("Последовательность не содержит");
            }
        }
        public static void PrintCheck555Result(string documentNumber)
        {
            // Проверить начинается ли номер документа с последовательности 555.
            string checkInt = "555";
            if (documentNumber.StartsWith(checkInt))
            {
                Console.WriteLine($"Номер документа начинается с {checkInt}");
            }
            else
            {
                Console.WriteLine($"Номер документа не начинается с {checkInt}");
            }
        }
        public static void PrintCheck1a2bResult(string documentNumber)
        {
            // Проверить заканчивается ли номер документа на последовательность 1a2b.
            string checkInt = "1a2b";
            if (documentNumber.StartsWith(checkInt))
            {
                Console.WriteLine($"Номер документа заканчивается на {checkInt}");
            }
            else
            {
                Console.WriteLine($"Номер документа не заканчивается на {checkInt}");
            }
        }
    }
}