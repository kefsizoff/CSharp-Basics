using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Joro
{
    static void Main()
    {
        string input = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine());
        int hometown = int.Parse(Console.ReadLine());

        double homePlays = hometown;
        double normalPlays = (52 - hometown) * 2 / 3.0;
        double holidayPlays = holidays * 0.5;

        double totalPlays = homePlays + normalPlays + holidayPlays;

        if (input == "t")
        {
            totalPlays += 3;
        }

        Console.WriteLine(Math.Floor(totalPlays));
    }
}