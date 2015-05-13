using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CalculateNFactKFact
{
    static void Main()
    {
        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("k= ");
        int k = int.Parse(Console.ReadLine());

        int factorial = 1;
        
        if (k > 1 && k < 100 && n > 1 && n < 100 && n > k)
        {
        
        for (int i = (k + 1); i <= n; i++)
        {
            factorial *= i;
        }
            Console.Write("n! / k! = ");
            Console.WriteLine(factorial);
        }
        else
        {
            Console.WriteLine("n must be greater than k and smaller than 100");
        }
    }
}