namespace Homework5Task4;

public class Motorcycle : Auto
{
    public bool isHaveSideCar = false;
    public Motorcycle(string brand, string number, int speedMax, int loadCapacity, bool isHaveSideCar) : base(brand, number, speedMax, loadCapacity)
    {
        this.isHaveSideCar = isHaveSideCar;
    }

    public override void GetAutoInfo()
    {
        if (!isHaveSideCar) this.LoadCapacity = 0;

        Console.WriteLine($"""
                Марка мотоцикла: {Brand}
                Номер: {Number}
                Скорость: {SpeedMax}
                Грузоподъемность: {LoadCapacity}
                Коляска: {(isHaveSideCar ? "да" : "нет")}
                """);
    }
}
