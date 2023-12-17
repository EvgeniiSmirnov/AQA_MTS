using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Homework6Task3.Documents;

// Контракт на поставку товаров
public class GoodsContract : Document
{
    public string GoodsType { get; set; } // тип товаров
    public int GoodsQuantity { get; set; } // количество товаров

    public GoodsContract() { }

    public GoodsContract(string documentNumber, DateTime documentDate, string goodsType, int goodsQuantity) : base(documentNumber, documentDate)
    {
        GoodsType = goodsType;
        GoodsQuantity = goodsQuantity;
    }

    public override void PrintDocumentInfo()
    {
        Console.WriteLine($"""
                Контракт на поставку товаров:
                Номер документа: {DocumentNumber}
                Дата документа: {DocumentDate}
                Тип товаров: {GoodsType}
                Количество товаров: {GoodsQuantity}
                """);
    }
}