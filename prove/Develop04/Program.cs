using System;
//Did NOT exceed core requirements this week (ran out of time).
class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        while (choice != 4)
        {
            Console.WriteLine("Menu Options:\n\t1. Breathing\n\t2. Reflecting\n\t3. Listing\n\t4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }
            else if (choice == 2)
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();
            }
            else if (choice == 3)
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }
        }
    }
}