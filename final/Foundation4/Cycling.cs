public class Cycling : Activity
{
    public double _speed /*in km/h*/ { get; set; }
    public Cycling(string name, DateTime date, double time, double speed) : base(name, date, time)
    {
        _speed = speed;
    }

    public override double getDistance()
    {
        return getSpeed() * _time / 60;
    }

    public override double getSpeed()
    {
        return _speed;
    }

    public override double getPace()
    {
        return 60 / getSpeed();
    }
}