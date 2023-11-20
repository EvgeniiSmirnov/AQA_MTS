/*Задание 4
Напишите программу, которая будет выполнять проверку чисел на четность.
Предложите два варианта решения поставленной задачи.
*/
//Вариант 1
Console.WriteLine("Проверка числа на чётность. Введите число:");
var number = Console.ReadLine();

char lastNumber;
if (number.Length > 1) lastNumber = number[number.Length - 1];
else lastNumber = Convert.ToChar(number);

switch (lastNumber)
{
    case '0':
    case '2':
    case '4':
    case '6':
    case '8':
        Console.WriteLine("чётное");
        break;
    case '1':
    case '3':
    case '5':
    case '7':
    case '9':
        Console.WriteLine("нечётное");
        break;
    default:
        Console.WriteLine("Ошибка! Вы ввели не число.");
        break;
}

//ヽ(°° )ノ Считать ли ноль чётным? https://en.wikipedia.org/wiki/Parity_of_zero

//Вариант 2
Console.WriteLine("Проверка числа на чётность. Введите число:");
var evenCheck = Convert.ToInt32(Console.ReadLine());
if ((evenCheck % 2) == 0)
{
    Console.WriteLine("чётное");
}
else
{
    Console.WriteLine("нечётное");
}