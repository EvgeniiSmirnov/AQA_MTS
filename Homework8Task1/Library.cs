using System.Collections;

namespace Homework8Task1;

internal class Library
{
    readonly ArrayList bookList = new();

    /// <summary>
    /// Метод добавляет книгу в библиотеку.
    /// </summary>
    /// <param name="book"></param>
    public void AddBook(Book book)
    {
        bookList.Add(book);
    }

    /// <summary>
    /// Метод выводит информацию о всех книгах в библиотеке.
    /// </summary>
    public void PrintLibraryInfo()
    {

        foreach (Book e in bookList)
        {
            Console.WriteLine($"""
               ---
               {e.BookTitle}
               {e.Author}
               {e.YearOfPublication}
               """);
        }
    }
    /// <summary>
    /// Метод выводит информацию о всех книгах в библиотеке по заданному автору, или сообщает об отсутствии таковых.
    /// </summary>
    /// <param name="author"></param>
    public void PrintBooksByAuthor(string author)
    {
        int count = 0;
        foreach (Book e in bookList)
        {
            if (e.Author.Equals(author))
            {
                Console.WriteLine($"""
               ---
               {e.BookTitle}
               {e.Author}
               {e.YearOfPublication}
               """);
            }
            else count++;

            if (count == bookList.Count) Console.WriteLine("Книг заданного автора нет в библиотеке");
        }
    }

    /// <summary>
    /// Метод удаляет книгу из библиотеки.
    /// </summary>
    /// <param name="book"></param>
    public void DeleteBook(Book book)
    {
        bookList.Remove(book);
    }

    /// <summary>
    /// Метод для выхода из программы библиотеки
    /// </summary>
    /// <param name="book"></param>
    public static void Exit()
    {
        Console.Write("Для выхода из программы нажмите любую клавишу");
        Console.ReadKey();
    }
}