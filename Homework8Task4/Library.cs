namespace Homework8Task4;

internal class Library
{
    public List<Book> libraryBookList = new();
    public HashSet<Book>? readerBooks;
    public Dictionary<Reader, HashSet<Book>> booksReaderSet = new();

    /// <summary>
    /// Метод добавляет книгу в библиотеку.
    /// </summary>
    /// <param name="book"></param>
    public void AddBook(Book book)
    {
        libraryBookList.Add(book);
    }

    /// <summary>
    /// Метод выдает книгу читателю. Если книга уже взята кем-то другим, выдает соответствующее сообщение
    /// </summary>
    /// <param name="reader"></param>
    /// <param name="book"></param>
    public void CheckOutBook(Reader reader, Book book)
    {
        // Пробуем выдать книгу
        if (libraryBookList.Remove(book))
        {
            // добавляем её к книгам читателя
            if (!booksReaderSet.TryGetValue(reader, out var readerBooks))
            {
                readerBooks = new() { book };
                booksReaderSet.Add(reader, readerBooks);
            }
            readerBooks.Add(book);
        }
        else Console.WriteLine("Данной книги нет в библиотеке");
    }

    /// <summary>
    /// Метод возвращает книгу в библиотеку
    /// </summary>
    /// <param name="reader"></param>
    /// <param name="book"></param>
    public void ReturnBook(Reader reader, Book book)
    {

        if (booksReaderSet.TryGetValue(reader, out readerBooks))
        {
            foreach (var item in readerBooks)
            {
                if (item.Equals(book))
                {
                    AddBook(book);
                    readerBooks.Remove(item);
                }
            }
        }
        else Console.WriteLine("Данной книги нет у читателя");
    }

    /// <summary>
    /// Метод отображает список книг в библиотеке
    /// </summary>
    public void PrintLibraryBookList()
    {
        Console.WriteLine("Список книг в библиотеке:");
        foreach (var e in libraryBookList)
        {
            Console.WriteLine($"""
               Название: {e.Title}
               Автор: {e.Author}
               ISBN: {e.ISBN}
               ---
               """);
        }
    }

    /// <summary>
    /// Метод отображает список книг у каждого читателя
    /// </summary>
    public void PrintReadersListWithBookSet()
    {
        foreach (var reader in booksReaderSet.Keys)
        {
            if (booksReaderSet.TryGetValue(reader, out readerBooks))
            {
                Console.WriteLine($"Список книг у читателя {reader.Name} (карта {reader.LibraryCardNumber}):");

                foreach (var e in readerBooks)
                {
                    Console.WriteLine($"""
                        Название: {e.Title}
                        Автор: {e.Author}
                        ISBN: {e.ISBN}
                        ---
                        """);
                }
            }
            else Console.WriteLine("Данный читатель не найден");
        }
    }
}