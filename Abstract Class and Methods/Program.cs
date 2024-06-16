using System;

public abstract class Shape
{
    public abstract double GetArea();
}

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

public class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override double GetArea()
    {
        return length * width;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(7.0);
        Rectangle rectangle = new Rectangle(4.0, 6.0);

        Console.WriteLine("Area of the circle: " + circle.GetArea());
        Console.WriteLine("Area of the rectangle: " + rectangle.GetArea());

        Console.ReadLine(); // Add this to prevent the console from closing immediately
    }
}