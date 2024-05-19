using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;

public class ListingActivity : Activity{
    private List<string> _count;
    private List<string> _prompts;

    public ListingActivity():base("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {}
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(GetRandomPrompt());
        ShowCountDown(8);
        GetListFromUser();
        Console.WriteLine($"{_count.Count()} items counted");

    }
    public string GetRandomPrompt()
    {
        return "";
    }
    public void GetListFromUser()
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