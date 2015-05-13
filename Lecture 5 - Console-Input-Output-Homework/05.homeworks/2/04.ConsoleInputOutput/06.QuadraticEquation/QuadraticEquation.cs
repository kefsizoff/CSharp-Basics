using System;

class QuadraticEquation
{
    static void Main()
    {
          int a, b, c, d;
        try
        {   Console.Write("a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {   Console.WriteLine("Invalid input");
            return;
        }
        if (a == 0)
        {   Console.WriteLine("Not a quadratic equation.");
            return;
        }
        d = b * b - 4 * a * c;
        if (d == 0)
            Console.WriteLine("x = {0}", -b / 2.0 / a);
        else if (d > 0)
            Console.WriteLine("x1 = {0}\nx2 = {1}", (-b + Math.Sqrt(d)) / 2 / a, (-b - Math.Sqrt(d)) / 2 / a);
        else if (d < 0)
            Console.WriteLine("No real roots");
        else
            Console.WriteLine("x1 = ({0},{1})\nx2 = ({0},-{1})", -b/2.0/a, Math.Sqrt(-d)/2/a);
    


    }
}
