using System;
using System.Collections.Generic;
using System.Linq;

class SortingNumbers
{
    static void Main(string[] args)
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter a number: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(numbers);
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
