using System;
using System.Collections.Generic;
using System.Linq;

class LongestNonDecreasingSubsequence
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input: ");
        string input = Console.ReadLine();

        string[] inputArray = input.Split();
        int length = inputArray.Length;
        int[] numbers = new int[length];
        long combinations = LengthToCombinations(length);

        int currentIndex = 0;
        foreach (string str in inputArray)
        {
            numbers[currentIndex] = int.Parse(str);
            currentIndex++;
        }

        List<int> longuestNonDecreasingSubsequence = new List<int>();
        for (long i = combinations; i >= 0; i--)
        {
            string currentCombination = Convert.ToString(i, 2).PadLeft(length, '0');
            List<int> currentSubsequence = new List<int>();
            for (int index = 0; index < currentCombination.Length; index++)
            {
                if (currentCombination[index] == '1')
                {
                    currentSubsequence.Add(numbers[index]); 
                }
            }

            bool isNonDecreasing = true;
            for (int index = 1; index < currentSubsequence.Count; index++)
            {
                if (currentSubsequence[index] < currentSubsequence[index - 1])
                {
                    isNonDecreasing = false;
                    break;
                }
            }

            if (isNonDecreasing)
            {
                if (currentSubsequence.Count > longuestNonDecreasingSubsequence.Count)
                {
                    longuestNonDecreasingSubsequence.Clear();
                    foreach (int number in currentSubsequence)
                    {
                        longuestNonDecreasingSubsequence.Add(number);
                    }
                }
            }
        }

        foreach (int number in longuestNonDecreasingSubsequence)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }

    private static long LengthToCombinations(int length)
    {
        long combinations = 1;
        for (int i = 1; i < length; i++)
        {
            combinations += (long)Math.Pow(2, i);
        }
        return combinations;
    }
}
