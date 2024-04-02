public class Receptions : Event
{
    public int rsvp { get; set; }

    public Receptions(string title, string description, DateTime date, string time, string address, int rsvp) : base(title, description, date, time, address)
    {
        this.rsvp = rsvp;
    }

    public void CreateEvent(List<Event> events)
    {
        events.Add(this);
    }
}