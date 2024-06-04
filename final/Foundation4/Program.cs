using System;

/*
I would like to share my personal thoughts on this assignment:


I feel that the scenario for this assignment was not a good demonstration of inheritance and polymorphism.

We should not need to override the methods because their functionality, as required by the scenario in this assignment, is identical between each class.
The only thing that truly varies between class is the starting information, or parameters.

Distance, pace, and speed are calculated the same way between each class. The summary function is the same too.
The only truly unique field was _laps in Swimming, and once we had the distance, the scenario never requires us to use this information again. 

In short, I do not understand why creating multiple classes was reasonable for this scenario.

I understand I did not fully follow the intructions in the grading rubic. I understand I may be docked points. I accept that. Thank you for reading my protest.
I have no negative feeling against my instructors, I simply wish to protest being required to write multiple classes, fields, and methods for a scenario that did not need it.
The assignment requirements felt contradictoy to the principles taught in this class. I hope you consider revising this scenario for future students.

Thank you for reading.
*/

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        activities.Add(new Running(30,2));//30 minutes, 2 miles
        activities.Add(new Cycling(15,10));//15 minutes, 10 mph
        activities.Add(new Swimming(60,60));//60 minutes, 60 laps
    

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());       
        }
    }
}