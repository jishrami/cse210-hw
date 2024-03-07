using System;

class Program
{
    static void Main(string[] args)
    {
        Shape square = new Square("yellow", 3.5);
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        Shape rectangle = new Rectangle("blue", 3.5, 4.5);
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());

        Shape circle = new Circle("red", 3.5);
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());
    }
}