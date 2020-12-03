using System;

//enumeration
enum color
{

    Red,
    Green,
    Blue
}

//abstract class "Shape" which has 3 methods pretaining to attributes of the shape.
abstract class Shape
{
    public abstract double getArea();
    public abstract double getPerimeter();
    public abstract color getColr();
}
//Triangle class which inherits the Shape methods
class Triangle : Shape
{
    public double s1;
    public double s2;
    public double s3;
    public color c = color.Red;

    public Triangle(double s1, double s2, double s3)
    {
        this.s1 = s1;
        this.s2 = s2;
        this.s3 = s3;

    }

    override
    public color getColr()
    {
        return c;
    }
    override
    public double getArea()
    {
        double p = getPerimeter();
        return Math.Sqrt(p * (p - s1) * (p - s2) * (p - s3));
    }
    override
    public double getPerimeter()
    {
        return ((s1 + s2 + s3) / 2);
    }
}

//Circle class which inherits the Shape methods and calculates area and perimeter
class Circle : Shape
{
    public double radius;
    public color colr = color.Green;
    public Circle(double radius)
    {
        this.radius = radius;

    }
    override
    public color getColr()
    {
        return this.colr;
    }
    override
    public double getArea()
    {
        return Math.PI * radius * radius;
    }
    override
    public double getPerimeter()
    {
        return 2 * Math.PI * radius;
    }


}

//Rectangle class which inherits the Shape methods and calculates area and perimeter
class Rectangle : Shape
{
    public double s1;
    public double s2;
    public color colr = color.Blue;
    public Rectangle(double s1, double s2)
    {
        this.s1 = s1;
        this.s2 = s2;

    }
    override
    public color getColr()
    {
        return this.colr;
    }
    override
    public double getArea()
    {
        return s1 * s2;
    }
    override
    public double getPerimeter()
    {
        return 2 * (s1 + s2);
    }
}

public class main
{
    static void Main(string[] args)
    {
        Triangle t = new Triangle(3.0, 4.0, 5.0);
        Console.WriteLine("Triangle Area: " + t.getArea());
        Console.WriteLine("Triangle Perimeter: " + t.getPerimeter());
        Console.WriteLine("Triangle Color " + t.getColr());

        Console.WriteLine("===================================================");

        Circle c = new Circle(3.0);
        Console.WriteLine("Circle Area: " + c.getArea());
        Console.WriteLine("Circle Perimeter: " + c.getPerimeter());
        Console.WriteLine("The color of Circle is " + c.getColr());

        Console.WriteLine("===================================================");

        Rectangle r = new Rectangle(3.0, 4.0);
        Console.WriteLine("Rectangle Area: " + r.getArea());
        Console.WriteLine("Rectangle Perimeter: " + r.getPerimeter());
        Console.WriteLine("Rectangle Color " + r.getColr());
    }
}