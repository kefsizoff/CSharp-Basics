using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter width of the rectangle: ");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter height of the rectangle: ");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("The perimeter of the rectangle is:{0} ", 2 * (width + height));
        Console.WriteLine("The area of the rectangle is:{0} ", width * height);
    }
}

