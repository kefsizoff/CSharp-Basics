﻿//Write a program to calculate the n-th Catalan number by given n (1 < n < 100).

using System;
using System.Numerics;

class CalculateCatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter an integer in the range (1 < n < 100):");
        int n = int.Parse(Console.ReadLine());
        BigInteger Factorial2N = 1;
        BigInteger FactorialN = 1;
        BigInteger FacturialNPlus1 = 1;

        if (n == 1 || n >= 100)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        for (int i = 1; i <= 2 * n; i++)
        {
            Factorial2N *= i;
            if (i <= n)
            {
                FactorialN *= i;
            }
        }

        for (int i = 1; i <= n + 1; i++)
        {
            FacturialNPlus1 *= i;
        }

        Console.WriteLine("Cn = {0}", Factorial2N / (FactorialN * FacturialNPlus1));
    }
}