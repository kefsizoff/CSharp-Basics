using System;
using System.Collections.Generic;

class JoinList
{
    static void Main()
    {
        string firstLine = Console.ReadLine();
        string secondLine = Console.ReadLine();
        
        HashSet<string> all = new HashSet<string>(firstLine.Split(' '));
        HashSet<string> second = new HashSet<string>(secondLine.Split(' '));

        all.UnionWith(second);
        
    }
}