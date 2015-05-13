using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrimeChecker
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        Console.WriteLine(IsPrime(n));
    }

    static bool IsPrime(ulong n)
    {
        bool isPrime = false;
        if (n == 1) return false;
        if (n == 2) return true;


        for (ulong i = 2; i <= Math.Ceiling(Math.Sqrt(n)); i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
            }
            else
            {
                isPrime = true;
            }
        }
        return isPrime;
    }
}