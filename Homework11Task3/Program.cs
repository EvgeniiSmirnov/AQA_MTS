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

        var sortedStringList = stringList.OrderBy(s => s.Length).ThenByDescending(s => s);

        // вывод элементов в консоль
        foreach (var num in sortedStringList) Console.Write($"{num} ");
    }
}