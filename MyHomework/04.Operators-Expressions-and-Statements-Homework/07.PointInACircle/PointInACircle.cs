using System;


class PointInACircle
{
    static void Main()
    {
        double x = 3;
        double y = 5;
        double hyp = Math.Sqrt(x * x + y * y);
        bool isIn = hyp <= 2 && hyp >= -2;

        Console.WriteLine(isIn);
    }
}
