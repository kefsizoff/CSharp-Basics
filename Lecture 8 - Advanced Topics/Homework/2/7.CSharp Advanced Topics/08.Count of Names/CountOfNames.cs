using System;
using System.Collections.Generic;
using System.Linq;

class CountOfNames
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] inputStringArray = input.Split();
        List<string> names = new List<string>(inputStringArray);
        names.Sort();
        HashSet<string> namesSet = new HashSet<string>(names);

        foreach (string name in namesSet)
        {
            int counter = 0;
            for (int i = 0; i < names.Count; i++)
            {
                if (names[i] == name)
                {
                    counter++;
                }
            }
            Console.WriteLine("{0} -> {1}", name, counter);
        }
    }
}

