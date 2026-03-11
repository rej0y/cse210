using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 3);
        Console.WriteLine($"Square color: {square.GetColor()}");
        Console.WriteLine($"Square area: {square.GetArea()}");

        Rectangle rectangle = new Rectangle("red", 4, 6);
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle("oranage", 8);
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());
        
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        Console.WriteLine();

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape color: {shape.GetColor()}");
            Console.WriteLine($"Shape Area: {shape.GetArea()}");
            Console.WriteLine();
        }
    }
}