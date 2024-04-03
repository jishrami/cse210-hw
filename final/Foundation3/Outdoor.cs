public class Outdoor : Event
{
    public string _weatherForecast { get; set; }

    public Outdoor(string type, string title, string description, DateTime date, string time, Address address, string weather) : base(type, title, description, date, time, address)
    {
        _weatherForecast = weather;
    }

    public override void DisplayFullEvent()
    {
        Console.WriteLine($"{_type}: {_title}");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"Weather: {_weatherForecast}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.GetFullAddress()}");
    }
}