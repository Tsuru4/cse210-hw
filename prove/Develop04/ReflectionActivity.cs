public class ReflectionActivity : Activity{

    private List<string> _prompts;
    private List<string> _questions;

    public ReflectionActivity():base("Reflection","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = ["experienced hardship.","had your worst health problems.", "failed at your goals.", "made an important invitation, but where rejected.","felt like you could not go on."];
        _questions = ["You are still here. How did you survive it?","Wasn't it worth it? How so?","What did you learn from it?","How did this help you draw closer to Jesus Christ?","Can you think of a time when Jesus Christ had a similar experience?","What are some things you have now that you didn't have back then?","How can the atonement of Jesus Christ help with you this even now?","How does the temple help with this experience?","Were you able to let God prevail?"];
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(GetRandomPrompt());
        int timer = GetDuration();
        while (timer > 0)
        {
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(8);
            timer -= 8;
        }
        DisplayEndingMessage();
    }
    private string GetRandomPrompt()
    {
        Random random= new Random();
        return "Think of a time when you " + _prompts[random.Next(_prompts.Count()-1)];
    }
    private string GetRandomQuestion()
    {
        Random random= new Random();
        return _questions[random.Next(_questions.Count()-1)];
    }
}