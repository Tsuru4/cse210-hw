using System;

class Program
{
    static void Main(string[] args)
    {
        string surname;
        string givenName;

        Console.WriteLine("What is your first name?");
        givenName = Console.ReadLine();
        
        Console.WriteLine("What is your last name?");
        surname = Console.ReadLine();

        Console.WriteLine($"Your name is {surname}, {surname} {givenName}.");
    }
}