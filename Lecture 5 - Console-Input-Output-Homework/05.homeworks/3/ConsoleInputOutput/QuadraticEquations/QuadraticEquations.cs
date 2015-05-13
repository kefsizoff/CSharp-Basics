using System;

class QuadraticEquations
{
    static void Main()
    {
        Console.Write("a= ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b= ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c= ");
        double c = double.Parse(Console.ReadLine());

        double x1 = 0;
        double x2 = 0;

        double d = b * b - 4 * a * c;

        if (d < 0)
        {
            Console.WriteLine("no real roots");
        }
        else if (d == 0)
        {
            x1 = (-b) / (2 * a);
            Console.WriteLine("x1=x2={0:F2}", x1);
        }
        else if (d > 0)
        {
            x1 = (-b - Math.Sqrt(d)) / (2 * a);
            x2 = (-b + Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("x1={0:F1}, x2={1:F1}", x1, x2);
        }
    }
}