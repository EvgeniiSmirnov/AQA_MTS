namespace Homework8Task4;

internal class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; } // уникальный идентификатор книги

    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }
}