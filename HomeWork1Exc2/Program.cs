/*Задание 2
Напишите программу определения, попадает ли введенное пользователем число (от -50 до 50)
в один из числовых промежутков [-40, -10] [-9, 0] [1, 10][11, 40].
Если да, то укажите, в какой именно промежуток.
Если пользователь указывает число, не входящее ни в один из имеющихся числовых промежутков,
то выводится соответствующее сообщение.
*/

Console.WriteLine("Введите число от -50 до 50:");
var userNum = Convert.ToDouble(Console.ReadLine());
if (userNum >= -40 && userNum <= -10)
{
    Console.WriteLine("[-40, -10]");
}
else if (userNum >= -9 && userNum <= 0)
{
    Console.WriteLine("[-9, 0]");
}
else if (userNum >= 1 && userNum <= 10)
{
    Console.WriteLine("[1, 10]");
}
else if (userNum >= 11 && userNum <= 40)
{
    Console.WriteLine("[11, 40]");
}
else 
{
    Console.WriteLine("Число не входит ни в один из имеющихся числовых промежутков");
}