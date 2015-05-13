using System;
using System.Linq;

class SumOfElements
{
    static void Main()
    {
        string[] inputData = Console.ReadLine().Split(' ');
        long[] numbers = new long[inputData.LongLength];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = long.Parse(inputData[i]);
        }

        long sum = numbers.Sum() - numbers.Max();

        if (sum == numbers.Max())
        {
            Console.WriteLine("Yes, sum={0}",sum);
        }
        else
        {
            Console.WriteLine("No, diff={0}",Math.Abs(sum-numbers.Max()));
        }
    }
}