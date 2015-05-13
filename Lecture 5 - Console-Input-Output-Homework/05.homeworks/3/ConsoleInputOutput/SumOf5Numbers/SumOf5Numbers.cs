using System;
using System.Linq;

class SumOf5Numbers
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');

        int[] output = new int[input.Length];

        for (int i = 0; i < output.Length; i++)
        {
            output[i] = int.Parse(input[i]);
        }

        Console.WriteLine(output.Sum());
    }
}