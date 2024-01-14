/*Задание 3:
Реализовать класс машина у которого будет обобщенное поле двигатель.
Создать иерархию наследования для двигателей (абстрактный, дизельный, бензиновый, электро).
Сделать так чтобы создать автомобиль можно было только передавая туда один из типов двигателя.
Реализовать методы для движения автомобиля.
*/

using Homework9Task3;

class Program
{
    static void Main()
    {
        Car<DieselEngine> carDiesel = new (new DieselEngine());
        carDiesel.MoveForward();
        carDiesel.MoveBackwards();

        Car<ElectricEngine> carElectric = new (new ElectricEngine());
        carElectric.MoveForward();
        carElectric.MoveBackwards();
    }
}