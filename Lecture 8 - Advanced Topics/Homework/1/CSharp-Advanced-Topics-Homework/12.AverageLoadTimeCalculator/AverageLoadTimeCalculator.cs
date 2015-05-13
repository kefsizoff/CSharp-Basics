using System;
using System.Collections.Generic;
using System.Linq;
class AverageLoadTimeCalculator
{
    static void Main()
    {
        string line = Console.ReadLine();
        Dictionary<string, double> dict = new Dictionary<string, double>();
        Dictionary<string, int> counters = new Dictionary<string, int>();
        int counter = 1;
        while (line != string.Empty)
        {
            string[] list = line.Split(' ');
            string link = list[2];
            double loadTime = double.Parse(list[3]);
            if (!dict.Keys.Contains(link))
            {
                dict[link] = loadTime; counters.Add(link,1);
                
            }
            else
            {
                counters[link] += 1;
                dict[link] = dict[link] + loadTime;
            }
            line = Console.ReadLine();
        }
        foreach (var link in dict.Keys)
        {
            Console.WriteLine("{0} -> {1}",link,dict[link]/counters[link]);
        }
        
        
    }
}
