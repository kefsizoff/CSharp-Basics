using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Triangle
{
    static void Main()
    {
        int ax = int.Parse(Console.ReadLine());
        int ay = int.Parse(Console.ReadLine());
        int bx = int.Parse(Console.ReadLine());
        int by = int.Parse(Console.ReadLine());
        int cx = int.Parse(Console.ReadLine());
        int cy = int.Parse(Console.ReadLine());

        double dAB = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
        double dBC = Math.Sqrt(Math.Pow(cx - bx, 2) + Math.Pow(cy - by, 2));
        double dCA = Math.Sqrt(Math.Pow(ax - cx, 2) + Math.Pow(ay - cy, 2));
        
        double a = dAB;
        double b = dBC;
        double c = dCA;
        double p = (a + b + c) / 2;
        
        if (a + b > c && b + c > a && a + c > b)
        {
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Yes");
            Console.WriteLine("{0:F2}", area);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:F2}", dAB);
        }
    }
}