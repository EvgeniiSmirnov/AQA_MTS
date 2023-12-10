namespace Homework5Task4;

public class Auto
{
    public string Brand { get; set; }
    public string Number { get; set; }
    public int SpeedMax { get; set; }
    public int LoadCapacity { get; set; }

    public Auto(string brand, string number, int speedMax, int loadCapacity)
    {
        Brand = brand;
        Number = number;
        SpeedMax = speedMax;
        LoadCapacity = loadCapacity;
    }

    public virtual void GetAutoInfo()
    {
    }
}
