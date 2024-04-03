public class Event
{
    public string _type { get; set; }
    public string _title { get; set; }
    public string _description { get; set; }
    public DateTime _date { get; set; }
    public string _time { get; set; }
    public Address _address { get; set; }

    public Event(string type, string title, string description, DateTime date, string time, Address address)
    {
        _type = type;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void StandardDisplay()
    {
        Console.WriteLine($"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.GetFullAddress()}");
    }

    public string ShortDisplay()
    {
        string standard = $"Event: {_type}\nTitle: {_title}\nDate: {_date}";
        return standard;
    }

    public virtual void DisplayFullEvent()
    {

    }

    public void DisplayEvent()
    {
        int userInput = 0;
        while (userInput != 4)
        {
            Console.WriteLine($"{_title}");
            Console.WriteLine($"Choose a viewing format:");
            Console.WriteLine("1. Standard\n2. Detailed\n3. Short\n4. Quit to next");
            userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    Console.Clear();
                    StandardDisplay();
                    break;
                case 2:
                    Console.Clear();
                    DisplayFullEvent();
                    break;
                case 3:
                    Console.Clear();
                    ShortDisplay();
                    break;
                case 4:
                    Console.Clear();
                    break;
            }
        }

    }

}