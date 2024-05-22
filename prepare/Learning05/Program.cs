using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Rectangle(3, 4, "Red"));
        shapes.Add(new Square(3, "Blue"));
        shapes.Add(new Circle(7, "Green"));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine ($"Area is {shape.GetArea()}. Color is {shape.GetColor()}.");
        }
    }
}