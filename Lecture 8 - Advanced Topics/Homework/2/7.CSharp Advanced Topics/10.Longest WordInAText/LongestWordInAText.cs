using System;
using System.Collections.Generic;
using System.Linq;

class LongestWordInAText
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        string[] words = text.Split(new char[]{' ',',','.',';',':','/','\\','\"'},StringSplitOptions.RemoveEmptyEntries);
        string longuestWord = "";

        foreach (string word in words)
        {
            if (word.Length > longuestWord.Length)
            {
                longuestWord = word;
            }
        }
        Console.WriteLine(longuestWord);
    }
}
