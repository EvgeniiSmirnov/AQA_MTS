namespace Homework9Task2;

internal class Generic<T>
{
    public T[] GenericArray { get; set; }

    public Generic(int length) => GenericArray = new T[length];

    /// <summary>
    /// Метод добавляет значение в массив
    /// </summary>
    /// <param name="value"></param>
    public void Add(T value)
    {
        List<T> tmp = new(GenericArray) { value };
        GenericArray = tmp.ToArray();
    }

    /// <summary>
    /// Метод удаляет элемент из массива
    /// </summary>
    /// <param name="value"></param>
    public void Delete(T value)
    {
        if (GenericArray.Contains(value))
        {
            List<T> tmp = new(GenericArray);
            tmp.Remove(value);
            GenericArray = tmp.ToArray();
        }
    }

    /// <summary>
    /// Метод выводим элементы массива в консоль
    /// </summary>
    public void Print()
    {
        foreach (var item in GenericArray)
            Console.Write(item + " ");

        Console.WriteLine();
    }

    /// <summary>
    /// Метод возвращем элемент по заданному индексу
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    public T GetElementByIndex(int index)
    {
        try
        {
            return GenericArray[index];
        }
        catch
        {
            throw new IndexOutOfRangeException("Индекс за пределами массива");
        }
    }

    /// <summary>
    /// Метод возвращает длину массива
    /// </summary>
    /// <returns></returns>
    public int GetArrayLenth() => GenericArray.Length;
}