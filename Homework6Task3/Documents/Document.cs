namespace Homework6Task3.Documents;

// базовый класс для всех документов
public abstract class Document
{
    public string DocumentNumber { get; set; }
    public DateTime DocumentDate { get; set; }

    public Document() { }

    public Document(string documentNumber, DateTime documentDate) : this()
    {
        DocumentNumber = documentNumber;
        DocumentDate = documentDate;
    }

    public abstract void PrintDocumentInfo();
}