using System;


class Rectangles
{
    static void Main()
    {
        double width = 5;
        double height = 5;
        double perimeter;
        double area;

        perimeter = 2 * (width + height);
        area = width * height;

        Console.WriteLine("The perimeter ot the rectangle is: {0} cm", perimeter);
        Console.WriteLine("The area of the rectangle is: {0} cm2", area);
    }
}
