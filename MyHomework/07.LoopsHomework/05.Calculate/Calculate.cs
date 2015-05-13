using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Calculate
{
    static void Main()
    {
        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("x= ");
        int x = int.Parse(Console.ReadLine());

        int factorial = 1;
        double S = 1;
        double m = 0;

        for (int i = 1; i <= n; i++)
        {
            factorial = factorial * i;
            m = factorial / Math.Pow(x, i);
            S = S + m;
        }

        Console.WriteLine("S = {0:F5}", S);

    }
}