namespace Homework6Task2;

// комплект товаров (несколько разных товаров)
public class Set : ProductBase
{
    public string ProductSetName { get; set; }
    public List<Product> Products { get; set; }
    public Set(string productSetName, List<Product> products)
    {
        ProductSetName = productSetName;
        Products = products;
    }

    // метод выводит информации о комплекте
    public override void GetInfo()
    {
        Console.WriteLine($"{ProductSetName}:");
        foreach (Product e in Products)
            e.GetInfo();
    }

    // метод проверяет срок годности каждого товара в комплекте относительно текущей даты
    public override void IsBestBefore(DateTime now)
    {
        foreach (Product e in Products)
            e.IsBestBefore(now);
    }
}