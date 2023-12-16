namespace Homework6Task2;

// класс товара
public class Product : ProductBase
{
    public string ProductName { get; set; }
    public double Price { get; set; }
    public DateTime ProductionDate { get; set; }
    public TimeSpan BestBefore { get; set; }

    public Product(string productName, double price, DateTime productionDate, TimeSpan bestBefore)
    {
        ProductName = productName;
        Price = price;
        ProductionDate = productionDate;
        BestBefore = bestBefore;
    }

    // метод выводит информации о товаре
    public override void GetInfo()
    {
        Console.WriteLine($"""
            Продукт: {ProductName}
            Цена: {Price}
            Дата производства: {ProductionDate}
            Срок годности (дни.часы.минуты): {BestBefore}
            """);
    }

    // метод проверяет срок годности товара относительно текущей даты
    public override void IsBestBefore(DateTime now)
    {
        if (now < ProductionDate.Add(BestBefore))
        {
            Console.WriteLine("Товар не просрочен");
        }
        else
        {
            Console.WriteLine("Товар просрочен");
        }
    }
}