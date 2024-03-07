using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Shape square = new Square("yellow", 3.5);
        shapes.Add(square);

        Shape rectangle = new Rectangle("blue", 3.5, 4.5);
        shapes.Add(rectangle);

        Shape circle = new Circle("red", 3.5);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}