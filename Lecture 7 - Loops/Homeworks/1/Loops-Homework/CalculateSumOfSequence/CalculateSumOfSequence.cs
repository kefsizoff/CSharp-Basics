//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn.
//Use only one loop. Print the result with 5 digits after the decimal point.

using System;

class CalculateSumOfSequence
{
    static void Main()
    {
        Console.Write("Enter value for n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter value for x: ");
        int x = int.Parse(Console.ReadLine());

        double sum = 1;
        double factorial = 1;
        int power = x;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            sum += factorial / x;
            x *= power;
        }
        Console.WriteLine("The sum is: {0 :F5}", sum);
    }
}