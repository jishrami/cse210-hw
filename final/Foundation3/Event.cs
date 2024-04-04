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

    public void ShortDisplay()
    {
        Console.WriteLine($"Event: {_type}\nTitle: {_title}\nDate: {_date}");
    }

    public virtual void DisplayFullEvent()
    {

    }

    public void DisplayEvent()
    {
        string userInput = " ";
        while (userInput != "4")
        {
            Console.Clear();
            Console.WriteLine($"Showing event: {_type} ");
            Console.WriteLine($"Choose a viewing format:");
            Console.WriteLine("1. Standard\n2. Detailed\n3. Short\n4. Quit to next");
            userInput = Console.ReadLine();
            Console.Clear();
            switch (userInput)
            {
                case "1":
                    StandardDisplay();
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "2":
                    DisplayFullEvent();
                    Console.Read();
                    Console.Clear();
                    break;
                case "3":
                    ShortDisplay();
                    Console.Read();
                    Console.Clear();
                    break;
                case "4":
                    Console.Clear();
                    break;
            }

           
        }

    }

}