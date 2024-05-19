public class ReflectionActivity : Activity{

    private List<string> _prompts;
    private List<string> _questions;

    public ReflectionActivity():base("Reflection","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
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
    public string GetRandomPrompt()
    {
        return "";
    }
    public string GetRandomQuestion()
    {
        return "";
    }
}