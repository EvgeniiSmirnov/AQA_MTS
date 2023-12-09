namespace Homework5Task2.DoctorModel;

public class Surgeon : Doctor
{
    public override void Heal()
    {
        Console.WriteLine("Хирург вас прооперировал");
    }
}