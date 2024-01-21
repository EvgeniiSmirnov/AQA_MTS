/*Задание 3:
Для приложения объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:
- метод имеет входной параметр типа int[];
- метод возвращает значение типа int[].
Дополнительно создать enum с типами сортировки (не менее 2-ух)
Реализовать метод, который на основании типа сортировки возвращает тип делегата.
Основная программа выполняет сортировку случайно сгененированного массива на основании выбранного типа.
*/

using Homework10Task3;
class Program
{
    public delegate int[] SortArray(int[] array);

    static void Main()
    {
        ArrayMethods array = new();

        // создадим два массива
        int[] arrayToSort1 = array.CreateArray();
        int[] arrayToSort2 = array.CreateArray();

        // выведем в консоль первый массив до и после сортировки
        Console.WriteLine("Первый массив до сортировки:");
        array.PrintArray(arrayToSort1);

        SortArray bubbleSort = SelectSortType(SortType.BubbleSort);      
        bubbleSort(arrayToSort1);
        Console.WriteLine("После сортировки:");
        array.PrintArray(arrayToSort1);

        // выведем в консоль второй массив до и после сортировки
        Console.WriteLine("Второй массив до сортировки:");
        array.PrintArray(arrayToSort2);

        SortArray ascSort = SelectSortType(SortType.AscendingSort);
        ascSort(arrayToSort2);
        Console.WriteLine("После сортировки:");
        array.PrintArray(arrayToSort2);

        // Метод возвращает тип делегата на основании типа сортировки
        SortArray SelectSortType(SortType type)
        {
            return type switch
            {
                SortType.BubbleSort => array.BubbleSort,
                SortType.AscendingSort => array.AscendingSort,
                _ => throw new Exception("Тип сортировки указан не корректно"),
            };
        }
    }

}