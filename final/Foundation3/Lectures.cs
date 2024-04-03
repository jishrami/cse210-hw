public class Lectures : Event
{
    public string _speaker { get; set; }
    public int _capacity { get; set; }

    public Lectures(string type, string title, string description, DateTime date, string time, Address address, string speaker, int capacity) : base(type, title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override void DisplayFullEvent()
    {
        Console.WriteLine($"{_type}: {_title}");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"Speaker: {_speaker} | Capacity: {_capacity}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.GetFullAddress()}");
    }
}