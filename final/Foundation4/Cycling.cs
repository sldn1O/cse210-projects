// Derived StationaryBicycles class
class StationaryBicycles : Activity
{
    private double speed;

    public StationaryBicycles(DateTime date, int minutes, double speed)
        : base(date, minutes)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetDistance()
    {
        return speed * minutes / 60;
    }

    public override double GetPace()
    {
        return 60 / speed;
    }
}
