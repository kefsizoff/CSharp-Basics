using System;
using System.Collections.Generic;
using System.Linq;
class JoinLists
{
    static void Main()
    {
        string inputNum1 = Console.ReadLine();
        string inputNum2 = Console.ReadLine();

        List<int> firstSequence = new List<int>(Array.ConvertAll(inputNum1.Split(' '), int.Parse));
        List<int> secondSequence = new List<int>(Array.ConvertAll(inputNum2.Split(' '), int.Parse));
        firstSequence.AddRange(secondSequence);
        firstSequence.Sort();
        int index = 0;
        while (index < firstSequence.Count - 1)
        {
            if (firstSequence[index] == firstSequence[index + 1])
            {
                firstSequence.RemoveAt(index);
            }
            else
            {
                index++;
            }
        }
        foreach (var number in firstSequence)
        {
            Console.WriteLine(number);
        }
    }
}
