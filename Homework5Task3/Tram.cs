namespace Homework5Task3;

// класс трамвая
public class Tram : PublicTransport
{
    public Tram(string destination, int busNumber, DateTime departureTime, int placeNumbers)
    {
        Destination = destination;
        BusNumber = busNumber;
        DepartureTime = departureTime;
        SeatNumber = placeNumbers;
    }

    public override void PrintTransportInfo()
    {
        Console.WriteLine($"""
                Номер трамвая: {BusNumber}
                Пункт назначения: {Destination}
                Время отправления: {DepartureTime}
                Число мест: {SeatNumber}
                """);
    }

    public override string GetTransportMovingType()
    {
        return "Рельсовый";
    }

}
