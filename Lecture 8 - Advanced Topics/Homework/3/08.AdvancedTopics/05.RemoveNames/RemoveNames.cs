using System;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {
        string firstLineName = Console.ReadLine();
        string secondLineName = Console.ReadLine();
        List<string> firstLine = new List<string>(firstLineName.Split(' '));
        List<string> secondName = new List<string>(secondLineName.Split(' '));
        foreach (string second in secondName)
        {
            for (int i = 0; i < firstLine.Count; i++)
            {
                firstLine.Remove(second);
            }
        }
        foreach (string name in firstLine)
        {
            Console.Write("{0} ", name);
        }
        Console.WriteLine();
    }
}