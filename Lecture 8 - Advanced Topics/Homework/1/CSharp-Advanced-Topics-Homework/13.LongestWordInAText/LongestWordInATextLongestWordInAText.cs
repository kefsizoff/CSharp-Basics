using System;
using System.Collections.Generic;
using System.Linq;
class LongestWordInATextLongestWordInAText
{
    static void Main()
    {
        string[] text = Console.ReadLine().Split(' ');
        string longestWord = text[0];
        for (int i = 0; i < text.Length; i++)
        {
            if (longestWord.Length < text[i].Length)
            {
                longestWord = text[i];
            }
        }
        Console.WriteLine(longestWord.Trim(',','.'));
        
    }
}
