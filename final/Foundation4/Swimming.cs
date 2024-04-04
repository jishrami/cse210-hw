public class Swimming : Activity
{
    public int _laps { get; set; }
    public Swimming(string name, DateTime date, double time, int laps) : base(name, date, time)
    {
        _laps = laps;
    }

    public override double getDistance()
    {
        return (double)_laps * 50 / 1000;
    }

    public override double getSpeed()
    {
        return getDistance() / _time * 60;
    }

    public override double getPace()
    {
        return 60 / getSpeed();
    }
}