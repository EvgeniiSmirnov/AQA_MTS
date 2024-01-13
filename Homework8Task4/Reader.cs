namespace Homework8Task4;

internal class Reader
{
    public string Name { get; set; }
    public int LibraryCardNumber { get; set; } // номер библиотечной карты читателя

    public Reader(string name, int libraryCardNumber)
    {
        Name = name;
        LibraryCardNumber = libraryCardNumber;
    }
}