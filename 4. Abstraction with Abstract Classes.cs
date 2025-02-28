using System;

abstract class Shape
{
    public abstract double CalculateArea();
}

class Circle: Shape
{
    public double Radius;
    public Circle(double radius)
    {
        Radius = radius;
    }
    public override double CalculateArea() {
        return Math.PI * Radius * Radius;
    } 
}

class Rectangle: Shape
{
    public double Length, Width;
    public Rectangle(double l, double w)
    {
        Length = l;
        Width = w;
    }
    public override double CalculateArea()
    {
        return Length * Width;
    }
}