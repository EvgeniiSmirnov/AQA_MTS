using Homework7Task2.Exceptions;
using System.Collections;

namespace Homework7Task2;

internal class Order
{
    private int OrderNumber { get; set; }
    private ArrayList OrderGoodsList { get; set; }
    private string OrderDeliveryAdress { get; set; }

    public Order(int orderNumber, ArrayList orderGoodsList, string orderDeliveryAdress)
    {
        OrderNumber = orderNumber;
        OrderGoodsList = orderGoodsList;
        OrderDeliveryAdress = orderDeliveryAdress;
    }

    public bool OrderCheck()
    {
        try
        {
            // Если номер заказа отрицательный, программа должна генерировать пользовательское исключение
            if (OrderNumber < 0)
            {
                throw new InvalidOrderNumberException("Ошибка! Номера заказа отрицательный");
            }
            // Если заказ не содержит товаров, программа должна генерировать пользовательское исключение
            else if (OrderGoodsList.Count == 0)
            {
                throw new EmptyOrderExceptionnamespace("Ошибка! Список товаров пуст");
            }
            // Если данные для доставки отсутствуют (например, пустой адрес), программа должна генерировать пользовательское исключение
            else if (string.IsNullOrEmpty(OrderDeliveryAdress))
            {
                throw new DeliveryInformationMissingException("Ошибка! Не указан адрес доставки");
            }
            else
            {
                return true;
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }
}