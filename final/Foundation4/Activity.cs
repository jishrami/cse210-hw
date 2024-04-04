using System.Dynamic;

public abstract class Activity
{
    public string _exerciseName { get; set; }
    public DateTime _date /*of exercise*/ { get; set; }
    public double _time /*in minutes*/ { get; set; }

    public Activity(string name, DateTime date, double time)
    {
        _exerciseName = name;
        _date = date;
        _time = time;
    }

    public virtual double getDistance()
    {
        return 0;
    }

    public virtual double getSpeed()
    {
        return 0;
    }

    public virtual double getPace()
    {
        return 0;
    }

    public virtual void displaySummary()
    {
        Console.WriteLine($"{_date} {_exerciseName} ({_time} min) - Distance {getDistance():0.00} km, Speed {getSpeed():0.00} kph, Pace {getPace():0.00} min per km");
    }

}