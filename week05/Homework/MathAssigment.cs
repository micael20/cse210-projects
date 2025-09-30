public class MathAssignment:Assignment
{
    private string _textbookSection;
    private string _problems;


    public MathAssignment(string studentname, string topic, string bookSection, string problem) : base(studentname, topic)
    {
        _textbookSection = bookSection;
        _problems = problem;
    }

    public string GetHomeworkList()
    {

        return $"{_textbookSection} {_problems}";

    }
}