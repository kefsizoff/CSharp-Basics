using System;
//Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). 
class PointInACircle
{
    static void Main()
    {
        float coordinateX = 0.9f;
        float coodinateY = -1.93f;
        bool insideCircle = false;
        if ((coordinateX * coordinateX) + (coodinateY * coodinateY) < 4)
        {
            insideCircle = true;
            Console.WriteLine(insideCircle);
        }
        else
        {
            Console.WriteLine(insideCircle);
        }
    }
}

