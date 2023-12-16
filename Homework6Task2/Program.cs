/*
Задание 2:
Реализовать полную структуру классов и их взаимосвязь продумать самостоятельно. 
- Исходные данные: база (массив) из n товаров задать непосредственно в коде (захардкодить);
- Создать базовый класс Product с методами, позволяющим вывести на экран информацию о товаре, а также определить,
соответствует ли она сроку годности на текущую дату;

Создать производные классы:
- Продукт (название, цена, дата производства, срок годности),
- Партия (название, цена, количество шт, дата производства, срок годности),
Комплект (названия, цена, перечень продуктов) со своими методами вывода информации на экран, и определения соответствия сроку годности.

Создать базу (массив) из n товаров, вывести полную информацию из базы на экран,
а также организовать поиск просроченного товара (на момент текущей даты).
*/

using Homework6Task2;

public class Program
{
    public static void Main()
    {
        DateTime todayProductDate = DateTime.Today.Add(new TimeSpan(8, 0, 0)); // текущая дата выпуска товара

        // создаём массив товаров
        Product[] products =
        {
            new Product("Хлеб белый", 55, new DateTime(2023, 11, 10), new TimeSpan(7, 0, 0, 0)),
            new Product("Батон молочный", 55, todayProductDate, new TimeSpan(10, 0, 0, 0)),
            new Product("Молоко", 100, todayProductDate, new TimeSpan(5, 0, 0, 0)),
            new Product("Кофе", 350, new DateTime(2023, 06, 01), new TimeSpan(365, 0, 0, 0)),
            new Product("Онигири", 150, todayProductDate, new TimeSpan(0, 12, 0, 0)),
            new Product("Печенье", 200, new DateTime(2023, 12, 01), new TimeSpan(90, 00, 0, 0)),
        };

        // выводим информацию о товарах на экран ( + указываем просрочен на текущую дату или нет)
        foreach (Product e in products)
        {
            e.GetInfo();
            e.IsBestBefore(DateTime.Now);
            Console.WriteLine();
        }

        // создаём массив партий и комплектов
        Random rnd = new();

        ProductBase[] productsBathAndSet =
        {
            new Batch(products[rnd.Next(5)],rnd.Next(100)),
            new Batch(products[rnd.Next(5)],rnd.Next(100)),
            new Batch(products[rnd.Next(5)],rnd.Next(100)),
            new Set("Набор удачный", new List<Product>{products[rnd.Next(5)],products[rnd.Next(5)],products[rnd.Next(5)]}),
            new Set("Набор на каждый день", new List<Product>{products[rnd.Next(5)],products[rnd.Next(5)],products[rnd.Next(5)]}),
        };

        // выводим информацию о партиях и комплектах на экран ( + указываем просрочен на текущую дату или нет)
        Console.WriteLine("====== Партии и комплекты ========");
        foreach (ProductBase e in productsBathAndSet)
        {
            e.GetInfo();
            e.IsBestBefore(DateTime.Now);
            Console.WriteLine();
        }
    }
}