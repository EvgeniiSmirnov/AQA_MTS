﻿/*Задание 2:
Предположим, у вас есть система для обработки заказов в интернет-магазине.
Вам нужно написать программу, которая проверяет корректность данных при создании заказа. Каждый заказ имеет уникальный номер.

Задача: Напишите программу, используя блоки try-catch, создайте свой класс исключения и используйте оператор throw, чтобы обрабатывать следующие сценарии:
- Некорректный номер заказа: Если номер заказа отрицательный, программа должна генерировать пользовательское исключение InvalidOrderNumberException.
- Пустой список товаров: Если заказ не содержит товаров, программа должна генерировать пользовательское исключение EmptyOrderException.
- Недостаточные данные для доставки: Если данные для доставки отсутствуют (например, пустой адрес),
программа должна генерировать пользовательское исключение DeliveryInformationMissingException.
*/