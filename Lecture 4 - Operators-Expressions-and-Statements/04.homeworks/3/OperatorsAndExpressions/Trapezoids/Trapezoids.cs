using System;

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Enter trapezoid's sides :");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine("The area of the trapezoid is:{0} ", ((a + b) / 2) * h);

    }
}

