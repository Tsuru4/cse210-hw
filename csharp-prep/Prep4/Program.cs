using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput = 0; 
        List<int> integers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            userInput = int.Parse(Console.ReadLine());
            if (userInput != 0)
            {
            integers.Add(userInput);
            }
        }
        while (userInput != 0);

        int sum = 0;
        int largest = integers[0];
        foreach(int i in integers)
        {
            sum += i;
            if (largest < i)
            {
                largest = i;
            }
        }
        double average = (double)sum / integers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}