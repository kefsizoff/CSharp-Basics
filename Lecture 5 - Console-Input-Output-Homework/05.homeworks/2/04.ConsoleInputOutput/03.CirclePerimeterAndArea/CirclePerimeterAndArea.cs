using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("r:");
        double r = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * r;
        double area = Math.PI * r * r;
        Console.WriteLine("Perimeter: {0:0.00}", perimeter);
        Console.WriteLine("Area: {0:F2}", area);


    }
}
