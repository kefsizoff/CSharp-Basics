using System;
using System.Collections.Generic;
using System.Linq;

class PointClass
{
    static void Main()
    {
        Points pts = new Points(5,7);
        Points pt = new Points(9,2);
        Points p = new Points(-1,2);
        Console.WriteLine(pts.X);
        Console.WriteLine(pt.Y);
        Console.WriteLine(p.X);
    }
    
}
class Points
{
    public int X { get; set; }
    public int Y { get; set; }

    public Points(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }
}
