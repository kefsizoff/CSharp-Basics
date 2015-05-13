//Write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops

using System;
using System.Numerics;

class CalculateFactorialExpression
{
    static void Main()
    {
        Console.Write("Enter value for n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter value for k: ");
        int k = int.Parse(Console.ReadLine());

        if (k <= 1 || k > n || n <= 1 || n >= 100 || k >= 100)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        BigInteger factorialN = 1;
        int factorialK = 1;
        BigInteger factorialNK = 1;

        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
            if (i <= k)
            {
                factorialK *= i;
            }
        }

        for (int i = 1; i <= n - k; i++)
        {
            factorialNK *= i;
        }

        Console.WriteLine("{0}", factorialN / (factorialK * (factorialNK)));
    }
}