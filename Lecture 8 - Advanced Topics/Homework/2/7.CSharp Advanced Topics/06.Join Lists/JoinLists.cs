using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
    static void Main(string[] args)
    {
        string firstInput = Console.ReadLine();
        string secondInput = Console.ReadLine();

        string[] firstInputStringArray = firstInput.Split();
        string[] secondInputStringArray = secondInput.Split();

        int[] firstIntArray = ParseValues(firstInputStringArray);
        int[] secondIntArray = ParseValues(secondInputStringArray);

        List<int> allNumbers = new List<int>(firstIntArray);
        allNumbers.AddRange(secondIntArray);
        allNumbers.Sort();

        HashSet<int> allElements = new HashSet<int>(allNumbers);
        foreach (int number in allElements)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }

    private static int[] ParseValues(string[] inputStringArray)
    {
        int[] intArray = new int[inputStringArray.Length];
        int index = 0;
        foreach (string str in inputStringArray)
        {
            intArray[index] = int.Parse(str);
            index++;
        }
        return intArray;
    }
}