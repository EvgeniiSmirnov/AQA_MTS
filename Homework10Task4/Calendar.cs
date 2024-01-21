namespace Homework10Task4;

internal class Calendar
{
    public delegate void EventDelegate(Event e);
    public event EventDelegate? Notification;
    private List<Event> EventsList { get; set; } = new();

    /// <summary>
    /// Метод добавляет событие в массив событий (календарь)
    /// </summary>
    /// <param name="e"></param>
    public void AddEvent(Event e) => EventsList.Add(e);

    /// <summary>
    /// Метод выбирает события для текущей даты
    /// </summary>
    public void TodayEventNotification()
    {
        foreach (Event e in EventsList)
            // в условии задачи привязка только по дате
            if (DateOnly.FromDateTime(DateTime.Now).Equals(DateOnly.FromDateTime(e.Date)))
            {
                Notification?.Invoke(e);
            }
    }
}