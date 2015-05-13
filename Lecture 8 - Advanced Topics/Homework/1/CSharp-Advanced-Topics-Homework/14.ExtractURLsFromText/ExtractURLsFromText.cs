using System;
using System.Collections.Generic;
class ExtractURLsFromText
{
    static void Main()
    {
        string[] inputText = Console.ReadLine().Split(' ');
        List<string> text = new List<string>();
        foreach (var url in inputText)
        {
            if (!text.Contains(url) && url.Length > 6)
            {
                if (url.Substring(0,7) == "http://" || url.Substring(0,4) == "www.")
                {
                    text.Add(url);
                }
            }
        }
        Console.WriteLine();
        foreach (var url in text)
        {
            Console.WriteLine(url.Trim('.'));
        }
    }
}
