/*Задание 3:
Дана строковая последовательность. Строки последовательности содержат только заглавные буквы латинского алфавита.
Отсортировать последовательность по возрастанию длин строк, а строки одинаковой длины – по убыванию.
*/

class Programm
{
    public static void Main()
    {
        List<string> stringList =
            [
                "ABB",
                "AAA",
                "BBB",
                "CCC",
                "ADVL",
                "QWEQASD",
                "ASDASDA",
                "F"
            ];

        // сортируем по возрастанию, а одинаковые сортируем по убыванию
        var sortedStringList =
             (from str in stringList
              orderby str.Length
              select str).ThenByDescending(s => s);

        // вывод элементов в консоль
        foreach (var str in sortedStringList) Console.Write($"{str} ");
    }
}