using System;
using System.Linq;
class SumOfNNumbers
{
    static void Main()
    {
        //Write a program that enters a number n and after that enters more n 
        //numbers and calculates and prints their sum. Note that you may need to use a for-loop

        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());
        double[] numbers = new double[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("sum={0}",numbers.Sum());
    }
}