namespace Task1;
public class Phone
{
    public string number;
    public string model;
    public double weight;

    public Phone()
    {
        number = "79001122333";
        model = "testModel";
        weight = 0;
    }

    public Phone(string number, string model)
    {
        this.number = number;
        this.model = model;
        weight = 0;
    }

    public Phone(string number, string model, double weight) : this(number, model)
    {
        this.weight = weight;
    }

    // метод выводит на консоль сообщение “Звонит {name}”
    public void ReceiveCall(string callerName) => Console.Write($"Звонит {callerName}");

    // метод возвращает номер телефона
    public string GetPhoneNumber() => number;

    // метод выводит на консоль номера телефоном которым будет отправлено сообщение
    public void SendMessage(params string[] numbers)
    {
        foreach (string number in numbers)
            Console.WriteLine($"Сообщение будет отправлено на номер {number}");
    }
}