using System.Transactions;

public class Video {
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void DisplayInformation()
    {
        Console.WriteLine($"\n{_title}, {_author}, {_length} seconds:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.GetInformation());
        }
        Console.WriteLine();
    }
    public void GenerateComment(string name, string text)
    {
        _comments.Add(new Comment(name, text));
    }
}