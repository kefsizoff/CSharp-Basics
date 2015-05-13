using System;
using System.Collections.Generic;
using System.Linq;

class CountingAWordInAText
{
    static void Main(string[] args)
    {
        string word = Console.ReadLine();
        string input = Console.ReadLine();
        List<char> wordsSeparators = new List<char>();
        
        for (int i = 32; i < 127; i++) 
        {
            if ((i >= 32 && i <= 47) || (i >= 58 && i <= 64) || (i >= 91 && i <= 96) || (i >= 123 && i <= 126)) //all characters in the ASCII table                                                                                                   
            {                                                                                                   //that aren't letters or digits serve as separators.
                wordsSeparators.Add((char)i);
            }
        }

        string[] words = input.Split(wordsSeparators.ToArray());

        int counter = 0;
        foreach (string currentWord in words)
        {
            if (currentWord.ToLower() == word.ToLower())
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}