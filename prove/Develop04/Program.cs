using System;
//Did NOT exceed core requirements this week (ran out of time).
class Program
{
    static void Main(string[] args)
    {
        BreathingActivity a1 = new BreathingActivity();
        ListingActivity a2 = new ListingActivity();
        ReflectionActivity a3 = new ReflectionActivity();
        a2.Run();
        a3.Run();
    }
}