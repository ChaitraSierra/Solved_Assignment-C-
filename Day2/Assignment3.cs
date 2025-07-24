// Assignment 3: Polymorphism – Shape Calculator
csharpCopyEditusing System;
abstract class Shape{
    public abstract double CalculateArea();
}
class Circle : Shape{
    public double Radius { get; set; }
    public Circle(double radius)
    {
        Radius = radius;
    }
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}
class Rectangle : Shape{
    public double Length { get; set; }
    public double Breadth { get; set; }
    public Rectangle(double length, double breadth)
    {
        Length = length;
        Breadth = breadth;
    }
    public override double CalculateArea()
    {
        return Length * Breadth;
    }
}
csharpCopyEdit// Main method class Program{
    static void Main(string[] args)
    {
        Shape shape1 = new Circle(5);
        Shape shape2 = new Rectangle(4, 6);
        Console.WriteLine($"Circle Area: {shape1.CalculateArea():F2}");
        Console.WriteLine($"Rectangle Area: {shape2.CalculateArea():F2}");
    }
}
