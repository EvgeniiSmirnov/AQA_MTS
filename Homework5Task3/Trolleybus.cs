namespace Homework5Task3;

// класс троллейбуса
public class Trolleybus : PublicTransport
{
    public Trolleybus(string destination, int busNumber, DateTime departureTime, int placeNumbers)
    {
        Destination = destination;
        BusNumber = busNumber;
        DepartureTime = departureTime;
        SeatNumber = placeNumbers;
    }

    public override void PrintTransportInfo()
    {
        Console.WriteLine($"""
                Номер троллейбуса: {BusNumber}
                Пункт назначения: {Destination}
                Время отправления: {DepartureTime}
                Число мест: {SeatNumber}
                """);
    }

    public override string GetTransportMovingType()
    {
        return "Электрический";
    }
}