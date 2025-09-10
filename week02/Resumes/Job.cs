using System.Diagnostics.Tracing;

public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_company}, {_jobTitle}, {_startYear}-{_endYear}");
    }

    internal void Display()
    {
        throw new NotImplementedException();
    }
}

