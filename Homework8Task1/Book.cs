namespace Homework8Task1;

internal class Book
{
    string BookTitle { get; set; }
    string Author { get; set; }
    int YearOfPublication { get; set; }

    public Book(string bookTitle, string author, int yearOfPublication)
    {
        BookTitle = bookTitle;
        Author = author;
        YearOfPublication = yearOfPublication;
    }

    public string GetBookTitle() => BookTitle;
    public string GetAuthor() => Author;
    public int GetYearOfPublication() => YearOfPublication;
}