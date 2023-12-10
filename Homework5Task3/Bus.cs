namespace Homework5Task3
{
    // класс автобуса
    public class Bus : PublicTransport
    {
        public Bus(string destination, int busNumber, DateTime departureTime, int seatNumber)
        {
            Destination = destination;
            BusNumber = busNumber;
            DepartureTime = departureTime;
            SeatNumber = seatNumber;
        }

        public override void PrintTransportInfo()
        {
            Console.WriteLine($"""
                Номер автобуса: {BusNumber}
                Пункт назначения: {Destination}
                Время отправления: {DepartureTime}
                Число мест: {SeatNumber}
                """);
        }

        public override string GetTransportMovingType()
        {
            return "Колёсный";
        }
    }
}
