namespace Homework5Task4;

public class Truck : Auto
{
    public bool isHaveTrailer = false;
    public Truck(string brand, string number, int speedMax, int loadCapacity, bool isHaveTrailer) : base(brand, number, speedMax, loadCapacity)
    {
        if (isHaveTrailer) this.LoadCapacity = LoadCapacity * 2;
        this.isHaveTrailer = isHaveTrailer;
    }

    public override void GetAutoInfo()
    {
        {
            Console.WriteLine($"""
                Марка грузовика: {Brand}
                Номер: {Number}
                Скорость: {SpeedMax}
                Грузоподъемность: {LoadCapacity}
                Прицеп: {(isHaveTrailer ? "да" : "нет")}
                """);
        }
    }
}
