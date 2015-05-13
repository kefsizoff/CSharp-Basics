using System;
//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5)
//and out of the rectangle R(top=1, left=-1, width=6, height=2). 
class PointInCyrcleAndOutRectangle
{
    static void Main()
    {
        float x = -100f;
        float y = -100f;
        bool insideCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= 1.5 * 1.5;
        bool outRectangle = (x > 5 || x < -1) || (y > 1 || y < -1);
        if (insideCircle && outRectangle)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
