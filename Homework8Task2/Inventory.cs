namespace Homework8Task2;

internal class Inventory
{
    readonly Dictionary<int, Goods> goodsList = new();

    /// <summary>
    /// Метод добавляет товар в каталог.
    /// </summary>
    /// <param name="good"></param>
    public void AddGood(Goods good)
    {
        // Пробуем присвоить товару уникальный идентификатор.
        int counter = 0;
        bool flag;
        do
        {
            if (goodsList.TryAdd(new Random().Next(100), good)) flag = true;
            else
            {
                counter++;
                flag = false;
            }

        } while (flag == false || counter == 10);

        if (flag == false && counter == 10) Console.WriteLine("Товар не добавлен. Не удалось создать уникальный идентификатор");
    }

    /// <summary>
    /// Поиск товара по идентификатору.
    /// </summary>
    public void FindGoodById()
    {
        Console.WriteLine("Поиск товара по ID. Выберите ID из списка:");
        foreach (var key in goodsList.Keys) Console.Write($"{key} ");
        // Запрашиваем из консоли ID
        if (goodsList.TryGetValue(Convert.ToInt32(Console.ReadLine()), out Goods good))
        {
            Console.WriteLine($"""
               ---
               Найден товар:
               Название: {good.Name}
               Цена: {good.Price}
               Количество: {good.Amount}
               """);
        }
        else Console.WriteLine("По заданному ID товар не найден");
    }

    /// <summary>
    /// Метод отображает список товаров в каталоге
    /// </summary>
    public void PrintGoodsListInfo()
    {
        Console.WriteLine("Список товаров в каталоге:");
        foreach (Goods e in goodsList.Values)
        {
            Console.WriteLine($"""
               ---
               Название: {e.Name}
               Цена: {e.Price}
               Количество: {e.Amount}
               """);
        }
    }

    // Вспомогательный метод. Выводит список товаров в инвентаре вместе с их ID
    public void PrintGoodsListInfoWithID()
    {
        foreach (var key in goodsList.Keys)
        {
            Console.WriteLine($"ID: {key} ");
            if (goodsList.TryGetValue(key, out Goods good))
            {
                Console.WriteLine($"""
               Название: {good.Name}
               Цена: {good.Price}
               Количество: {good.Amount}
               ---
               """);
            }
            else Console.WriteLine("По заданному ID товар не найден");
        }
    }

    /// <summary>
    /// Метод для обновления информации о товаре
    /// </summary>
    public void UpdateGoodInfo()
    {
        // выводим список весь список товаров вместе с ID
        Console.WriteLine("Список доступных для обновления товаров:");
        PrintGoodsListInfoWithID();

        // запрашиваем ID и характеристику которую хотим обновить
        Console.WriteLine();
        Console.WriteLine("Введите ID товара который хотите обновить");
        if (goodsList.TryGetValue(Convert.ToInt32(Console.ReadLine()), out Goods updatedGood))
        {
            Console.WriteLine($"""
               ---
               Найден товар:
               Название: {updatedGood.Name}
               Цена: {updatedGood.Price}
               Количество: {updatedGood.Amount}

               Укажите какую характеристику хотите обновить: 1 - Название, 2 - Цена, 3 - Количество
               """);

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Обновляем название. Введите новое значение:");
                    updatedGood.Name = Console.ReadLine() ?? "нет данных";
                    break;
                case 2:
                    Console.WriteLine("Обновляем Цену. Введите новое значение:");
                    updatedGood.Price = Convert.ToInt32(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("Обновляем Количество. Введите новое значение:");
                    updatedGood.Amount = Convert.ToInt32(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Номер характеристики указан не верно");
                    break;
            }

            Console.WriteLine($"""
               ---
               Товар с обновлёнными характеристиками:
               Название: {updatedGood.Name}
               Цена: {updatedGood.Price}
               Количество: {updatedGood.Amount}
               """);
        }
        else Console.WriteLine("По заданному ID товар не найден");
    }

    /// <summary>
    /// Метод для удаления товара из инвенторя
    /// </summary>
    public void DeleteGood()
    {
        Console.WriteLine("Удаление товаров");
        Console.WriteLine("Список доступных товаров:");
        PrintGoodsListInfoWithID();

        Console.WriteLine("Введите ID товара который необходимо удалить");
        goodsList.Remove(Convert.ToInt32(Console.ReadLine()));

        Console.WriteLine();
        Console.WriteLine("Список доступных товаров после удаления:");
        PrintGoodsListInfoWithID();
    }
}