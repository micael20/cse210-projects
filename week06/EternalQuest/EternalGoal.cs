public class EternalGoal : Goal
{
    private int _timesCompleted;

    public EternalGoal(string name, string description, int points, int timesCompleted = 0) 
        : base(name, description, points)
    {
        _timesCompleted = timesCompleted;
    }

    public override void RecordEvent()
    {
        _timesCompleted++;
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }

    public override string GetDetailsString()
    {
        return $"[ ] {GetShortName()} - {GetDescription()} (Completed {_timesCompleted} times)";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}|{_timesCompleted}";
    }
}
