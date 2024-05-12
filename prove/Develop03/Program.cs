using System;

//Exceeded core requirements by making the rate at which the words disappear customizable.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("One of the best ways to memorize a scripture is to write it yourself.");
        Console.WriteLine("Please enter the scripture reference. Or simply press enter to use the preset scripture:");
        string reference = Console.ReadLine();
        string text;
        if (reference == "")
        {
            reference = "2 Nephi 27: 20-21";
            text = "Then shall the Lord God say unto him: The learned shall not read them, for they have rejected them, and I am able to do my own work; wherefore thou shalt read the words which I shall give unto thee. Touch not the things which are sacred, for I will bring them forth in my own due time; for I will show unto the children of men that I am able to do my own work.";
        }
        else
        {
            Console.WriteLine("Please enter the text:");
            text = Console.ReadLine();
        }
        Console.WriteLine("Please select the probability at which you want words to disappear on a scale of 1:X\n (Must be an integer greater than 1. The lower the number, the faster the words disappear. 6 is recommended)");
        int ratio = int.Parse(Console.ReadLine());

        Scripture scripture = new Scripture(reference, text, ratio);
        
        string userInput = "";
        while (scripture.IsRemainingWords() && userInput != "quit")
        {
            Console.Clear();
            scripture.Write();
            Console.WriteLine("\nType quit to exit, otherwise press enter to continue. ");
            userInput = Console.ReadLine();
            scripture.HideRandom();
        }
    }
}