public class Event
{
    public string title { get; set; }
    public string description { get; set; }
    public DateTime date { get; set; }
    public string time { get; set; }
    public string address { get; set; }

    List<Event> events = new List<Event>();

    public Event(string title, string description, DateTime date, string time, string address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public void DisplayEvent()
    {
        Console.WriteLine("1. Standard\n2. Detailed\n3.Short");
        int userInput = int.Parse(Console.ReadLine());

        switch (userInput)
        {
            case 1:
                Console.WriteLine($"Title: {title}\nDescription: {description}\nDate: {date}\nTime: {time}\nAddress: {address}");
                break;
            case 2:
                Console.WriteLine($"Title: {title}\nDescription: {description}\nDate: {date}\nTime: {time}\nAddress: {address}"); //TODO add other class details
                break;
            case 3:
                Console.WriteLine($"Event: {typeof(Event)}\nTitle: {title}\nDate: {date}"); //TODO change typeof to Event type (class name)
                break;
        }

    }

}