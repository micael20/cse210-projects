public class Video
{
    private string _title;
    private string _author;
    private int _lengthVideo;
    private List<Comment> _comments;


    public Video(string title, string author, int lengthVideo)
    {
        _title = title;
        _author = author;
        _lengthVideo = lengthVideo;
        _comments = new List<Comment>();
    }

    // Responsibility: Track comments count
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Responsibility: Add comments (collaboration!)
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Responsibility: Display video info (could be separate method)
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthVideo} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            comment.DisplayInfo();
        }
        Console.WriteLine("----------------------");
    }
}