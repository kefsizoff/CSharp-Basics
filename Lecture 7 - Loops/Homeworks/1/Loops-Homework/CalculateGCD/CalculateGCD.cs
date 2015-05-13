//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet). 

using System;

class CalculateGCD
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        int remain = 1;

        while (remain != 0)
        {
            remain = a % b;
            a = b;
            b = remain;
        }
        Console.WriteLine("The greatest common divisor of a and b is " + Math.Abs(a));
    }
}