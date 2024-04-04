using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures lecture = new Lectures("Lecture", "Intro to C#", "C# is awesome", new DateTime(2022, 1, 1), "10:00 AM", new Address("123 Main St", "Anytown", "USA", "12345"), "Dr. Smith", 50);
        lecture.DisplayEvent();

        Receptions reception = new Receptions("Reception", "Wedding Reception", "John and Jane wedding", new DateTime(2022, 8, 3), "7:00 PM", new Address("123 Main St", "Anytown", "USA", "12345"), "wedding@example.com");
        reception.DisplayEvent();

        Outdoor outdoor = new Outdoor("Outdoor", "Parade", "Cinco de Mayo parade", new DateTime(2022, 5, 5), "9:00 AM", new Address("123 Main St", "Anytown", "USA", "12345"), "Sunny");
        outdoor.DisplayEvent();
    }
}