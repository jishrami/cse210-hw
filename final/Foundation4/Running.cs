public class Running : Activity
{
    public double _distance /*in kilometers*/ { get; set; }
    public Running(string name, DateTime date, double time, double distance) : base(name, date, time)
    {
        _distance = distance;
    }

    public override double getDistance()
    {
        return _distance;
    }

    public override double getSpeed()
    {
        return  _distance / _time * 60;
    }

    public override double getPace()
    {
        return _time / _distance;
    }
}