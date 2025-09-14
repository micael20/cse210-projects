public class PromptGenerator
{
    public List<string>_prompts;

    // Initializing the List by a special Method known as a (Constructor)
    public PromptGenerator()
    {
        _prompts = new List<string>();

        // Adding prompts to the List
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my Day?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What New ideas or things that I came across today");


    }

    public string GetRandomPrompt()
    {

        // Create a Random object
        Random random = new Random();

        // get a random index
        int index = random.Next(_prompts.Count);

        //accessing the prompt
        string prompt = _prompts[index];

        return prompt;
    }

}