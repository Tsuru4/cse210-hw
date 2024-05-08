using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction a = new Fraction();
        a.SetTop(3);
        a.SetBottom(4);
        Console.WriteLine($"{a.GetTop()}/{a.GetBottom()}");
        Console.WriteLine($"{(double)a.GetTop()/a.GetBottom()}");
        Console.WriteLine("That was a bad way to use a class");
        Console.WriteLine();

        Fraction b = new Fraction(5);
        Console.WriteLine(b.GetFractionString());
        Console.WriteLine(b.GetDecimalValue());
        Console.WriteLine("That was slightly better.");
        Console.WriteLine("");

        Fraction c = new Fraction(1,2);
        c.WriteFractionString();
        c.WriteDecimalValue();
        Console.WriteLine("Encapsulation means my class can do its own work :)");
    }
}