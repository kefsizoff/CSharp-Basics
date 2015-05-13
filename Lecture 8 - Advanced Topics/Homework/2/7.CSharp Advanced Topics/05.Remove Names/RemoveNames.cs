using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNames
{
    static void Main(string[] args)
    {
        string inputNames = Console.ReadLine();
        string inputNamesToRemove = Console.ReadLine();

        string[] inputNamesArray = inputNames.Split();
        string[] inputNamesToRemoveArray = inputNamesToRemove.Split();

        List<string> names = new List<string>(inputNamesArray);
       
        foreach (string nameToRemove in inputNamesToRemoveArray)
        {
            while (names.Contains(nameToRemove))
            {
                names.Remove(nameToRemove);
            }
        }

        foreach (string name in names)
        {
            Console.Write(name + " ");
        }
        Console.WriteLine();
    }
}
