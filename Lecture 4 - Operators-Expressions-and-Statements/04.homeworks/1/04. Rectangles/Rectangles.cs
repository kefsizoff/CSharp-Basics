using System;
//Write an expression that calculates rectangle’s perimeter and area by given width and height.
class Rectangles
{
    static void Main()
    {
        float width = 2.5f;
        float height = 3;
        float perimeter = 2 * width + 2 * height;
        float area = width * height;
        Console.WriteLine("Perimeter is {0}",perimeter);
        Console.WriteLine("Area is {0}",area);
    }
}

