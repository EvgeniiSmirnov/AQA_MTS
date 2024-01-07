namespace Homework8Task1;

internal class Book
{
    string bookTitle = "";
    string author = "";
    int yearOfPublication = 0;
    public string BookTitle
    {
        get => bookTitle;
        private set => bookTitle = value;
    }

    public string Author
    {
        get => author;
        private set => author = value;
    }

    public int YearOfPublication
    {
        get => yearOfPublication;
        private set => yearOfPublication = value;
    }

    public Book(string bookTitle, string author, int yearOfPublication)
    {
        BookTitle = bookTitle;
        Author = author;
        YearOfPublication = yearOfPublication;
    }
}