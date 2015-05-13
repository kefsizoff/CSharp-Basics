using System;
class LongestAreaInArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] words = new string[n];
        for (int i = 0; i < n; i++)
        {
            words[i] = Console.ReadLine().ToLower();
        }
        int startIndex = 0;
        int lengthCount = 1;
        int currentCount = 1;
        for (int i = 0; i < words.Length - 1; i++)
        {
            if (words[i] == words[i + 1])
            {
                currentCount++;
                if (currentCount > lengthCount)
                {
                    lengthCount = currentCount;
                    startIndex = (i + 1) - (lengthCount - 1);
                }
            }
            else
            {
                currentCount = 1;
            }
        }
        Console.WriteLine();
        Console.WriteLine(lengthCount);
        for (int i = 0; i < lengthCount; i++)
        {
            Console.WriteLine(words[startIndex + i]);
        }
    }
}
