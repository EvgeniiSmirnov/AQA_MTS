namespace Homework5Task4;

internal class PassengerCar : Auto
{
    public PassengerCar(string brand, string number, int speedMax, int loadCapacity) : base(brand, number, speedMax, loadCapacity)
    {
    }

    public override void GetAutoInfo()
    {
        Console.WriteLine($"""
                Марка легкового авто: {Brand}
                Номер: {Number}
                Скорость: {SpeedMax}
                Грузоподъемность: {LoadCapacity}
                """);
    }
}
