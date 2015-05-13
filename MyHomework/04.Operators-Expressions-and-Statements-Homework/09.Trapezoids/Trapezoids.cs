using System;

class Trapezoids
{
    static void Main()
    {
        double a = 0.222;
        double b = 0.333;
        double h = 0.555;

        double area = a * h + (b - a) * 0.5 * h;

        Console.WriteLine("Area: {0} cm2", area);
    }
}
