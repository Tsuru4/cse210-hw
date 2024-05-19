using System.Transactions;

public abstract class Activity{
    private string _activityName;
    private string _description;
    private int _duration;

    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }


    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"{_activityName}: {_description}");
        Console.WriteLine("How long will the activity be? (seconds):");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Prepare to begin...");
        ShowSpinner(4);
    }
    protected void DisplayEndingMessage()
    {
        Console.WriteLine("Good Job.");
        ShowSpinner(4);
        Console.WriteLine($"You completed the {_activityName} activity for {_duration} seconds.");
        ShowSpinner(4);
    }
    protected void ShowSpinner(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }
    protected void ShowCountDown(int seconds)
    {
        while (seconds > 0)
        {
            
            Console.Write(seconds);
            Thread.Sleep(1000);
            seconds -= 1;
            Console.Write("\b \b");
        }
    }
    protected int GetDuration()
    {
        return _duration;
    }
}