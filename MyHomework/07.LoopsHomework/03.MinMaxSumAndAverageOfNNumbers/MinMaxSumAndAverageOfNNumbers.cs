using System;
using System.Linq;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array1 = new int [n];

        for (int i = 0; i < n; i++)
        {
            int input = int.Parse(Console.ReadLine());
            array1[i] = input;
        }
        Console.WriteLine("min = {0}", array1.Min());
        Console.WriteLine("max = {0}", array1.Max());
        Console.WriteLine("sum = {0}", array1.Sum());
        Console.WriteLine("avg = {0:F2}", array1.Average());
    }
}