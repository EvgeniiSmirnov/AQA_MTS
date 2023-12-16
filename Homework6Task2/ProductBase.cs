namespace Homework6Task2;

// Создать базовый класс Product с методами, позволяющим вывести на экран информацию о товаре, а также определить,
// соответствует ли она сроку годности на текущую дату
public abstract class ProductBase
{
    // вывод информации на экран
    public abstract void GetInfo();

    // проверка срока годности на текущую дату
    public abstract void IsBestBefore(DateTime now);
}