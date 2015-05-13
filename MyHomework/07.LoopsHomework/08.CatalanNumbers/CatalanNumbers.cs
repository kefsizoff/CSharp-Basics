using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


class CatalanNumbers
{
    static void Main()
    {
        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());

        BigInteger factorial = 1;
        BigInteger nFactorial = 1;
        BigInteger result;

        if (1 < n && n < 100)
        {

            for (int i = 1; i <=2 * n; i++)
            {
                factorial *= i;
                if (i <= n)
                {
                    nFactorial *= i;
                }
            }


            result = factorial / (nFactorial * (n + 1) * nFactorial);
            Console.WriteLine(result);
        }
        else if (n == 0 || n == 1)
        {
            Console.WriteLine("Catalan = {0}", 1);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}