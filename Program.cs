/*Adam Lenarduzzi
  C#
  HW-3
 */
using System;

//enumeration
enum color
{

    Red,
    Green,
    Blue,
    Black
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
    public double side1;
    public double side2;
    public double side3;
    public color colr;

    public Triangle(double side1, double side2, double side3)
    {
        var rnd = new Random();
        colr = (color)rnd.Next(Enum.GetNames(typeof(color)).Length);
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }

    override
    public color getColr()
    {
        return colr;
    }
    override
    public double getArea()
    {
        double p = getPerimeter();
        return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
    }
    override
    public double getPerimeter()
    {
        return ((side1 + side2 + side3) / 2);
    }
}

//Circle class which inherits the Shape methods and calculates area and perimeter
class Circle : Shape
{
    public double radius;
    public color colr;
    public Circle(double radius)
    {
        var rnd = new Random();
        colr = (color)rnd.Next(Enum.GetNames(typeof(color)).Length);
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
    public double side1;
    public double side2;
    public color colr;
    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
        var rnd = new Random();
        colr = (color)rnd.Next(Enum.GetNames(typeof(color)).Length);
    }
    override
    public color getColr()
    {
        return this.colr;
    }
    override
    public double getArea()
    {
        return side1 * side2;
    }
    override
    public double getPerimeter()
    {
        return 2 * (side1 + side2);
    }
}

public class main
{
    static void Main(string[] args)
    {
        Triangle t = new Triangle(7.0, 5.0, 4.0);
        Console.WriteLine("Triangle Area: " + t.getArea());
        Console.WriteLine("Triangle Perimeter: " + t.getPerimeter());
        Console.WriteLine("Triangle Color: " + t.getColr());

        Console.WriteLine("===================================================");

        Circle c = new Circle(36.0);
        Console.WriteLine("Circle Area: " + c.getArea());
        Console.WriteLine("Circle Perimeter: " + c.getPerimeter());
        Console.WriteLine("Circle Color: " + c.getColr());

        Console.WriteLine("===================================================");

        Rectangle r = new Rectangle(5.0, 10.0);
        Console.WriteLine("Rectangle Area: " + r.getArea());
        Console.WriteLine("Rectangle Perimeter: " + r.getPerimeter());
        Console.WriteLine("Rectangle Color: " + r.getColr());
    }
}