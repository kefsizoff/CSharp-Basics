//Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop.

using System;
using System.Numerics;

class CalculateFactorialDivision
{
    static void Main()
    {
        Console.Write("Enter value for n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter value for k: ");
        int k = int.Parse(Console.ReadLine());

        BigInteger factorialN = 1;
        BigInteger factorialK = 1;

        if (1 < k && k < n && n < 100)
        {
            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
                if (i <= k)
                {
                    factorialK *= i;
                }
            }
            Console.WriteLine("N!/K! = {0}", factorialN / factorialK);
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}