namespace Homework6Task2;

// партия товаров (несколько одинаковых товаров)
public class Batch : ProductBase
{
    public int Quantity { get; set; } // количество товара
    public Product Product { get; set; } // товар

    public Batch(Product product, int quantity)
    {
        Product = product;
        this.Quantity = quantity;
    }

    // метод выводит информации о партии
    public override void GetInfo()
    {
        Console.WriteLine("Партия продуктов:");
        Product.GetInfo();
        Console.WriteLine($"Количество:{Quantity}");
    }

    // метод проверяет срок годности партии относительно текущей даты
    public override void IsBestBefore(DateTime now)
    {
        if (now < Product.ProductionDate.Add(Product.BestBefore))
        {
            Console.WriteLine("Партия не просрочена");
        }
        else
        {
            Console.WriteLine("Партия просрочен");
        }
    }
}