using System;

//Write a program that reads the radius r of a circle and prints its 
//perimeter and area formatted with 2 digits after the decimal point. 

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Please write the radius in cm:");
        double radius = double.Parse(Console.ReadLine());

        
        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * Math.Pow(radius, 2);

        Console.WriteLine("The perimeter of the circle is: {0:0.00} cm", perimeter);
        Console.WriteLine("The area of the circle is: {0:F2} cm2", area);
    }
}
