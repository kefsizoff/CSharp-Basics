using System;
using System.Collections.Generic;
class SortingNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        SortNumbers(n);
    }

    static void SortNumbers(int n)
    {
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(numbers);
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
