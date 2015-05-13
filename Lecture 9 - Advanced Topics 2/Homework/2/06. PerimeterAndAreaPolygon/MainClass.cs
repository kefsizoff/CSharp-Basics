using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MainClass
{
    public static void Main()
    {
        Polygon poly = new Polygon();

            poly.Points.Add(new Point(0, 0));
            poly.Points.Add(new Point(0, 1));
            poly.Points.Add(new Point(1, 1));
        

        Console.WriteLine(poly.GetPerimeter());
    }
}

