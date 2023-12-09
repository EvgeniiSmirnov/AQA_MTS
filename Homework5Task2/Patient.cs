using Homework5Task2.DoctorModel;

public class Patient
{
    Surgeon surgeon = new();
    Dantist dantist = new();
    Therapist therapist = new();

    public string name;
    public int age;
    public int treatmentPlan;

    public Patient(string name, int age, int treatmentPlan)
    {
        this.name = name;
        this.age = age;
        this.treatmentPlan = treatmentPlan;
    }

    // лечение пациента согласно коду плану лечения
    public void HealingByTreatmentPlan()
    {
        switch (treatmentPlan)
        {
            case 1:
                Console.WriteLine("Назначен хирург");
                surgeon.Heal();
                break;
            case 2:
                Console.WriteLine("Назначен стоматолог");
                dantist.Heal();
                break;
            default:
                Console.WriteLine("Назначен терапевт");
                therapist.Heal();
                break;
        }
    }
}