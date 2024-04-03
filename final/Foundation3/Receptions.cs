public class Receptions : Event
{
    public int _rsvp { get; set; }

    public Receptions(string type, string title, string description, DateTime date, string time, Address address, int rsvp) : base(type, title, description, date, time, address)
    {
        _rsvp = rsvp;
    }

    public override void DisplayFullEvent(){

        Console.WriteLine($"{_type}: {_title}");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"RSVP: {_rsvp}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.GetFullAddress()}");
    }
}