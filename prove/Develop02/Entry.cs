public class Entry
{
    public string _prompt;
    public string _date;
    private string _year;
    private string _month;
    private string _day;
    public string _userResponse;

    public Entry()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        _prompt = promptGenerator.Generate();

        Console.WriteLine(_prompt);
        _userResponse = Console.ReadLine();

        DateTime dateTime = DateTime.Now;
        _year = dateTime.Year.ToString("");
        _month = DoubleDigitToString(dateTime.Month);
        _day = DoubleDigitToString(dateTime.Day);
        _date = _month + "-" + _day + "-" + _year;

        Console.WriteLine(_date);
    }

    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _userResponse = response;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_userResponse}");
        Console.WriteLine();
    }

    private string DoubleDigitToString(int i)
    {
        string timeString = i.ToString("");
        if (i < 10)
        {
            timeString = "0" + timeString;
        }
        return timeString;
    }

}