namespace Homework11Task2;

class Client(int clientID, int year, int month, int trainingHours)
{
    public int ClientID { get; set; } = clientID;
    public int Year { get; set; } = year;
    public int Month { get; set; } = month;
    public int TrainingHours { get; set; } = trainingHours;
}