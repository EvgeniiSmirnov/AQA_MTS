/*Задание 3:
Коллекция содержит набор чисел в виде одной строки "1, 2, 3, 4, 4, 5".
Избавиться от повторяющихся элементов в строке и вывести результат на экран.
*/

using System.Collections;

class Program
{
    public static void Main()
    {
        List<int> list = new() { 1, 2, 3, 4, 4, 5 };
        Print(list);

        Console.WriteLine();
        Print(new HashSet<int>(list));
    }

    public static void Print(IEnumerable collection)
    {
        foreach (int e in collection)
        {
            Console.Write($"{e} ");
        }
    }
}