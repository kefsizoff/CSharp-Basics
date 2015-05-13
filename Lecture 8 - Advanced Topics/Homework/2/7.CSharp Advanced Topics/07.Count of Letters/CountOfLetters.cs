using System;
using System.Collections.Generic;
using System.Linq;

class CountOfLetters
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] inputStringArray = input.Split();
        List<string> chars = new List<string>(inputStringArray);
        chars.Sort();
        HashSet<string> charsSet= new HashSet<string>(chars);

        foreach (string character in charsSet)
        {
            int counter = 0;
            for (int i = 0; i < chars.Count; i++)
            {
                if (chars[i] == character)
                {
                    counter++;
                }
            }
            Console.WriteLine("{0} -> {1}", character, counter);
        }
    }
}