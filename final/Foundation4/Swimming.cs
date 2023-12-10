// Derived Swimming class
class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return (laps * 50 / 1000) / minutes * 60;
    }

    public override double GetPace()
    {
        return minutes / (laps * 50 / 1000);
    }
}
