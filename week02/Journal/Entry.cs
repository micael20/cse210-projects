public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    // added mood variable
    public string _mood;

    public void Display()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"Mood: {_mood}"); 
        Console.WriteLine($"{_entryText}");
        Console.WriteLine();


    }
}