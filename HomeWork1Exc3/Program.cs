/*Задание 3
Напишите программу русско-английский переводчик.
Программа знает 10 слов о погоде.
Требуется, чтобы пользователь вводил слово на русском языке, а программа давала ему перевод этого слова на английском языке.
Если пользователь ввел слово, для которого отсутствует перевод, то следует вывести сообщение, что такого слова нет.
*/
Console.WriteLine("Это русско-английский погодный переводчик.\nВведите требуемое слово на русском:");
var rusWord = Console.ReadLine();
switch (rusWord.ToLower())
{
    case "холодно":
    case "холод":
        Console.WriteLine("cold");
        break;
    case "тепло":
        Console.WriteLine("warm");
        break;
    case "жарко":
        Console.WriteLine("hot");
        break;
    case "солнечно":
        Console.WriteLine("sunny");
        break;
    case "ветренно":
        Console.WriteLine("windy");
        break;
    case "туманно":
    case "туман":
        Console.WriteLine("foggy");
        break;
    case "oблачно":
        Console.WriteLine("cloudy");
        break;
    case "дождливо":
    case "дождь":
        Console.WriteLine("rainy");
        break;
    case "ливень ":
        Console.WriteLine("hard hain");
        break;
    case "град ":
        Console.WriteLine("hail");
        break;
    default:
        Console.WriteLine("Переводчик не знает такого слова");
        break;
}