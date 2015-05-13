using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Globalization;

class AverageLoadTimeCalculator
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        List<string> loader = new List<string>();
        string input;
        Console.WriteLine("Натиснете Enter когато сте готови с входящите данни, за да се изпише резултата!");
        
        while (true)
        {
            input = Console.ReadLine();
            if (input == "")
            {
                break;
            }
            else
            {
                loader.Add(input);
            }
        }

        HashSet<string> sites = new HashSet<string>();
        string[,] sitesAndTime = new string[loader.Count,2];
        for (int i = 0; i < loader.Count; i++)
        {
            string site = GetSite(loader[i]);
            sites.Add(site);
            FillUpSitesAndTime(sitesAndTime, loader[i], i);
        }
        
        foreach (string site in sites)
        {
            double sumTime = 0;
            int counter = 0;
            for (int i = 0; i < sitesAndTime.GetLength(0); i++)
            {
                if (sitesAndTime[i,0] == site)
                {
                    sumTime += double.Parse(sitesAndTime[i, 1]);
                    counter++;
                }
            }
            double averageTime = sumTime / counter;
            Console.WriteLine("{0} -> {1}",site, averageTime);
        }
    }

    private static void FillUpSitesAndTime(string[,] sitesAndTime, string nextRecord, int index)
    {
        string[] records = nextRecord.Split();
        sitesAndTime[index, 0] = records[2];
        sitesAndTime[index, 1] = records[3];
    }

    private static string GetSite(string nextRecord)
    { 
        string[] records = nextRecord.Split();
        string currentSite = records[2];
        return currentSite;
    }
}
