namespace Homework6Task3.Documents;

// Контракт с сотрудником
public class EmployeeContract : Document
{
    public DateTime DocumentEndDate { get; set; } // Дата окончания контракта
    public string EmployeeName { get; set; } // Имя сотрудника

    public EmployeeContract() { }

    public EmployeeContract(string documentNumber, DateTime documentDate, DateTime documentEndDate, string employeeName) : base(documentNumber, documentDate)
    {
        DocumentEndDate = documentEndDate;
        EmployeeName = employeeName;
    }

    public override void PrintDocumentInfo()
    {
        Console.WriteLine($"""
                Контракт с сотрудником:
                Номер документа: {DocumentNumber}
                Дата документа: {DocumentDate}
                Дата окончания контракта: {DocumentEndDate}
                Имя сотрудника: {EmployeeName}
                """);
    }
}
