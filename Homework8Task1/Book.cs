namespace Homework8Task1;

internal class Book
{
    public string BookTitle { get; private set; }

    public string Author { get; private set; }

    public int YearOfPublication { get; private set; }

    public Book(string bookTitle, string author, int yearOfPublication)
    {
        BookTitle = bookTitle;
        Author = author;
        YearOfPublication = yearOfPublication;
    }
}