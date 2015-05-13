using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        //Write a program that reads the radius r of a circle and prints its perimeter and area formatted 
        //with 2 digits after the decimal point

        Console.Write("r= ");
        double r = double.Parse(Console.ReadLine());

        double p = Math.PI * 2 * r;
        double s = Math.PI * r * r;

        Console.WriteLine("Perimeter: {0:F2}, Area: {1:F2}",p,s);
    }
}