using System;
using System.Collections.Generic;
using System.Linq;

class LongestAreaInArray
{
    static void Main(string[] args)
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());
        string[] numbers = new string[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Console.ReadLine();
        }

        string maxElement = numbers[0];
        int maxElementCount = 0;
        
        for (int i = 0; i < numbers.Length; i++)
        {
            string nextElement = numbers[i];
            int nextElementCount = 0;
            for (int j = i; j < numbers.Length; j++)
            {
                if (numbers[j] == nextElement)
                {
                    nextElementCount++;
                }
            }
            if (nextElementCount > maxElementCount)
            {
                maxElementCount = nextElementCount;
                maxElement = nextElement;
            }
        }
        Console.WriteLine();
        Console.WriteLine(maxElementCount);
        for (int i = 0; i < maxElementCount; i++)
        {
            Console.WriteLine(maxElement);
        }
    }
}
