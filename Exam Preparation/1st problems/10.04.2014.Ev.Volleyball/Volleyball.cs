using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Volleyball
{
    static void Main()
    {
        string year = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine());
        int hometown = int.Parse(Console.ReadLine());

        int homePlays = hometown;
        double normal = (48 - hometown) * 0.75;
        double holidayPlays = holidays * 2 / 3.0;
        double totalPlays = normal + holidayPlays + homePlays;

        if (year == "leap")
        {
            totalPlays = totalPlays * 1.15;
        }
        Console.WriteLine(Math.Floor(totalPlays));
    }
}