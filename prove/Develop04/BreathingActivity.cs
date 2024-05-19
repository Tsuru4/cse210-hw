public class BreathingActivity : Activity{

    public BreathingActivity():base("Reflecting","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing")
    {}
    public void Run()
    {
        DisplayStartingMessage();
        int timer = GetDuration();
        while(timer > 0)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(6);
            Console.WriteLine("Now breathe out...");
            ShowCountDown(4);
            timer-=10;
        }

        DisplayEndingMessage();
    }
}