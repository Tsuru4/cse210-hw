using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;

public class ListingActivity : Activity{
    private List<string> _count;
    private List<string> _prompts;

    public ListingActivity():base("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = ["How did you show love toward your neighbor today?","How did God show you love recently?","How do you show your faith in Christ?","Who has helped you?","Who will miss you when you are gone?", "Who has had an impact on your life?","What are your greatest life decisions?"];
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(GetRandomPrompt());
        ShowCountDown(8);
        GetListFromUser();
        Console.WriteLine($"{_count.Count()} items counted");
        DisplayEndingMessage();

    }
    private string GetRandomPrompt()
    {
        Random random= new Random();
        return _prompts[random.Next(_prompts.Count()-1)];
    }
    private void GetListFromUser()
    {
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(GetDuration());
        _count = new List<String>();
        Console.WriteLine("Begin:");
        while (currentTime < endTime)
        {
            _count.Add(Console.ReadLine());
            currentTime = DateTime.Now;
        }
    }
}