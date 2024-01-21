namespace Homework10Task4;

internal class Event(string title, DateTime date, string description)
{
    public string Title { get; set; } = title;
    public DateTime Date { get; set; } = date;
    public string Description { get; set; } = description;

    /// <summary>
    /// Метод выводит данные о событии в консоль
    /// </summary>
    /// <param name="e"></param>
    public static void PrintEventInfo(Event e)
    {
        Console.WriteLine($"Дата: {DateOnly.FromDateTime(e.Date)}, событие: {e.Title}, описание: {e.Description}");
    }
}