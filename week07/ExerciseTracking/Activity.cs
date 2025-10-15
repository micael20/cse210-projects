public abstract class Activity
{
    private string _date;
    private int _length; // in minutes

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public string GetDate() { return _date; }
    public int GetLength() { return _length; }

    // These methods will be different for each activity
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // This method works the same for all activities
    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_length} min) - " +
               $"Distance: {GetDistance():F1} miles, " +
               $"Speed: {GetSpeed():F1} mph, " +
               $"Pace: {GetPace():F1} min per mile";
    }
}