using System;

class Calculator
{
    public int Add(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine($"Adding {a} and {b} results in {sum}");
        return sum;
    }

    public int Add(int x, int y, int z)
    {
        int sum = x + y + z;
        Console.WriteLine($"Adding {x}, {y}, and {z} results in {sum}");
        return sum;
    }

    public double Add(double x, double y) 
    {
        double sum = x + y;
        Console.WriteLine($"Adding {x} and {y} results in {sum}");
        return sum;
    }
}
