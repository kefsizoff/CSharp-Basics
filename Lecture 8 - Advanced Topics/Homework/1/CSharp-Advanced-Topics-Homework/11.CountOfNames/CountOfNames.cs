using System;
using System.Collections.Generic;
class CountOfNames
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        List<string> names = new List<string>();
        for (int i = 0; i < input.Length; i++)
        {
            names.Add(input[i]);
        }
        names.Sort();
        int counter = 1;
        for (int i = 1; i < names.Count; i++)
        {
            if (names[i] == names[i - 1])
            {
                counter++;
            }
            else
            {
                Console.WriteLine("{0} -> {1}",names[i - 1],counter);
                counter = 1;
            }

            if (i == names.Count - 1)
            {
                Console.WriteLine("{0} -> {1}", names[i], counter);                
            }
        }
    }
}
