//Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//Your program should work well for very big numbers, e.g. n=100000

using System;

class TrailingZeroesInFactorial
{
    static void Main()
    {
        Console.Write("N = ");
        int number = int.Parse(Console.ReadLine());
        int zeroCount = 0;
        int d;

        for (int i = 5; i <= number; i += 5)
        {
            d = i;
            while (d % 5 == 0)
            {
                d /= 5;
                zeroCount++;
            }
        }
        Console.WriteLine("Trailing zeroes: " + zeroCount);
    }
}