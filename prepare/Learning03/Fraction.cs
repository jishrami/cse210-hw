class Fraction
{
    private int _topNumber;
    private int _bottomNumber;

    public Fraction ()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction (int top)
    {
        _topNumber = top;
        _bottomNumber = 1;
    }

    public Fraction (int top, int bottom)
    {
        _topNumber = top;
        _bottomNumber = bottom;
    }

    public string GetFractionString ()
    {
        return ($"{_topNumber}/{_bottomNumber}");
    }

    public double GetDecimalValue ()
    {
        double fraction = (double)_topNumber / _bottomNumber;
        return fraction;
    }
}