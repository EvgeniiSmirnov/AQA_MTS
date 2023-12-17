namespace Homework6Task3.Documents;

// Финансовая накладная
public class FinancialInvoice : Document
{
    public int TotalMonthAmount { get; set; } // Итоговая сумма за месяц
    public int DepartmentCode { get; set; } // Код департамента

    public FinancialInvoice() { }

    public FinancialInvoice(string documentNumber, DateTime documentDate, int totalMonthAmount, int departmentCode) : base(documentNumber, documentDate)
    {
        TotalMonthAmount = totalMonthAmount;
        DepartmentCode = departmentCode;
    }
    public override void PrintDocumentInfo()
    {
        Console.WriteLine($"""
                Финансовая накладная:
                Номер документа: {DocumentNumber}
                Дата документа: {DocumentDate}
                Итоговая сумма за месяц: {TotalMonthAmount}
                Код департамента: {DepartmentCode}
                """);
    }
}