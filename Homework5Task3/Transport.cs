namespace Homework5Task3;

public class Transport
{

    //Пункт назначения, Номер, Время отправления, Число мест
    public string Destination { get; set; }
    public int BusNumber { get; set; }
    public DateTime DepartureTime { get; set; }
    public int SeatNumber { get; set; }


    // метод возвращает тип транспорта: электрический, колёсный, рельсовый
    public virtual string GetTransportMovingType()
    {
        return "Не определено";
    }

    //метод который нельзя переопределить т.к.он не объявлен виртуал
    public void DestroyTransport()
    {
        Console.WriteLine("Транспорт уничтожен");
    }

    public virtual void PrintTransportInfo()
    {
    }
}
