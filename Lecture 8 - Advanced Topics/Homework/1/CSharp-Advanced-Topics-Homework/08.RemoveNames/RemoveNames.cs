using System;
using System.Collections.Generic;
using System.Linq;
class RemoveNames
{
    static void Main()
    {
        string[] firstNames = Console.ReadLine().Split(' ');
        string[] secondNames = Console.ReadLine().Split(' ');

        List<string> firstlistOfNames = firstNames.ToList();
        List<string> secondlistOfNames = secondNames.ToList();

        for (int i = 0; i < secondlistOfNames.Count; i++)
        {
            for (int j = 0; j < firstlistOfNames.Count; j++)
            {
                if (firstlistOfNames.Contains(secondlistOfNames[i]))
                {
                    firstlistOfNames.Remove(secondlistOfNames[i]);
                }
            }
        }
        foreach (var name in firstlistOfNames)
        {
            Console.Write(name + " ");
        }
        Console.WriteLine();
    }
}
