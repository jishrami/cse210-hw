public class Lectures : Event
{
    public string speaker { get; set;}
    public int capacity { get; set;}

    public Lectures(string title, string description, DateTime date, string time, string address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public void CreateEvent(List<Event> events)
    {
        events.Add(this);
    }
}