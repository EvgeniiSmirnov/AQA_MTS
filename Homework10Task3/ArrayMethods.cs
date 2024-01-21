namespace Homework10Task3;

internal class ArrayMethods
{
    /// <summary>
    /// Метод генерирующий массив
    /// </summary>
    /// <returns></returns>
    public int[] CreateArray()
    {
        Random rnd = new();
        int arrayLength = rnd.Next(10, 20); // произвольная длина массива в промежутке от 10 до 20
        int[] arrayToSort = new int[arrayLength];

        // инициализируем элементы массива числами от -50 до 50
        for (int i = 0; i < arrayLength; i++)
        {
            arrayToSort[i] = rnd.Next(-50, 50);
        }

        return arrayToSort;
    }

    /// <summary>
    /// Метод сортирует массив пузырьковой сортировкой
    /// </summary>
    /// <param name="arrayToSort"></param>
    /// <returns></returns>
    public int[] BubbleSort(int[] arrayToSort)
    {
        int tmp;

        // сортируем элементы (самый большой должен уйти в конец)
        for (int i = 0; i < arrayToSort.Length; i++)            // левые элементы 
            for (int j = i + 1; j < arrayToSort.Length; j++)    // правые
                if (arrayToSort[i] > arrayToSort[j])            // если левый больше правого, то меняем их местами
                {
                    tmp = arrayToSort[i];
                    arrayToSort[i] = arrayToSort[j];
                    arrayToSort[j] = tmp;
                }
        return arrayToSort;
    }

    /// <summary>
    /// Метод сортирует элементы по возрастанию с использованием метода класса Array
    /// </summary>
    /// <param name="arrayToSort"></param>
    /// <returns></returns>
    public int[] AscendingSort(int[] arrayToSort)
    {
        Array.Sort(arrayToSort); // сортируем элементы
        return arrayToSort;
    }

    /// <summary>
    /// Метод вывовид элементы массива в консоль
    /// </summary>
    /// <param name="array"></param>
    public void PrintArray(int[] array)
    {
        foreach (int i in array)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}