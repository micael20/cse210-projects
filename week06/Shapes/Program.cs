using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");


        Rectangle rectangle = new Rectangle(12, 4);
        double area = rectangle.GetArea();
        Console.WriteLine(area)

        Square square = new Square(4);
        double area = square.GetArea();
        Console.WriteLine(area)

        Circle circle = new circle(6);
        double area = circle.GetArea();
        Console.WriteLine(area)
    }
}