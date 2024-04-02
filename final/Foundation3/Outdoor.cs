public class Outdoor : Event
{
    public string weatherForecast { get; set; }

    public Outdoor(string title, string description, DateTime date, string time, string address, string weather) : base(title, description, date, time, address)
    {
        weatherForecast = weather;
    }

    public void CreateEvent(List<Event> events)
    {
        events.Add(this);
    }
}