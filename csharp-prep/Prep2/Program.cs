using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        double percentage = double.Parse(Console.ReadLine());
        
        char letter;
        string sign = "";

        if (percentage >=90)
        {
            letter = 'A';
        }
        else if (percentage >=80)
        {
            letter = 'B';
        }
        else if (percentage >=70)
        {
            letter = 'C';
        }
        else if (percentage >=60)
        {
            letter = 'D';
        }
        else
        {
            letter = 'F';
        }
        
        if ((percentage%10 >=7)&&(letter!='A')&&(letter!='F'))
        {
            sign = "+";
        }
        else if ((percentage%10<3)&&(letter!='F')&&(percentage<=90))
        {
            sign= "-";
        }
        

        Console.WriteLine($"Your grade is {letter}{sign}!");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratualations on passing your class!");
        }
        else
        {
            Console.WriteLine("Mistakes are meant to be learned from! Never give up!");
        }

    }
}