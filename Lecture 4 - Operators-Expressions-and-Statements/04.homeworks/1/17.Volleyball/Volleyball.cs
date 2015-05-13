using System;
class Volleyball
{
    static void Main()
    {
        string isLeapYear = Console.ReadLine();
        int numberOfHolidays = int.Parse(Console.ReadLine());
        int weekendHomeTown = int.Parse(Console.ReadLine());
        int totalWeekends = 48;
        int normalWeekend = totalWeekends - weekendHomeTown;
        double playsInHolidays = 2 * numberOfHolidays / 3.0;
        double normalWeekendPlays = 3 * normalWeekend / 4.0;
        double totalPlays = weekendHomeTown + playsInHolidays + normalWeekendPlays;
        if (isLeapYear == "leap")
        {
            totalPlays = (int)(totalPlays * 1.15);
        }
        Console.WriteLine(Math.Floor(totalPlays)); ;
    }
}

