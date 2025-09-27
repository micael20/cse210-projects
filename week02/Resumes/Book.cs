public class Book
{
    public string _title;
    public string _author;

    public int _yearPublished;

    public Book()
    {

    }

    public void DisplayBookInfo()
    {
        if (_yearPublished > DateTime.Now.Year)
        {
            Console.WriteLine($"{_title}-{_author}, INVALID PUBLICATION");
            return;
        }
        int age = DateTime.Now.Year - _yearPublished;
        Console.WriteLine($"{_title}-{_author}, {_yearPublished} is aged {age}");
    }

}