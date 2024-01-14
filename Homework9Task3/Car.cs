namespace Homework9Task3;

internal class Car<T>
{
    public T Engine { get; set; } // обобщенное поле двигатель

    public Car(T engine) => Engine = engine;

    public void MoveBackwards() => Console.WriteLine("Машина едет назад");

    public void MoveForward() => Console.WriteLine("Машина едет вперёд");
}