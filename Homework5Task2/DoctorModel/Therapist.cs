namespace Homework5Task2.DoctorModel;

public class Therapist : Doctor
{
    public override void Heal()
    {
        Console.WriteLine("Терапевт вас обследовал");
    }
}