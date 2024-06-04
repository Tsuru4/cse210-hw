using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events= new List<Event>();
        events.Add(new Lecture("Tuesday's Devotional","A spiritual thought provided by campus faculty.", "June 4th, 2024", "12PM", "BYU-I center","Elder McConkie", 3000));
        events.Add(new Reception("John and Jane Doe's wedding reception", "Come and celebrate with the newlyweds as they beign their new life together!","February 31st, 2037", "2AM", "1234, E 4th street, Salem, Mars", "JJDoe@marscolonizers.com"));
        events.Add(new OutdoorGathering("Rabbit Hunt","Come hunting with Elmer Fudd! It's wabbit season!","July 6th, 1957", "8AM", "Valhalla, Asgard", "Thunder and Lighting"));

        foreach(Event e in events)
        {
            Console.WriteLine(e.ShortDescription());
            Console.WriteLine(e.StandardDetails());
            Console.WriteLine(e.FullDetails());
        }
    }
}