using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ExamSchedule
{
    static void Main()
    {
        int startHour = int.Parse(Console.ReadLine());
        int startMin = int.Parse(Console.ReadLine());
        string partOfDay = Console.ReadLine();
        int durationHours = int.Parse(Console.ReadLine());
        int durationMins = int.Parse(Console.ReadLine());

        bool amPM;
        if (partOfDay == "AM")
        {
            amPM = true;
        }
        else
        {
            amPM = false;
        }

        int mins = startMin + durationMins;
        int hours = startHour + durationHours;
        if (mins > 59)
        {
            mins -= 60;
            hours++;
        }
        if (hours > 12)
        {
            hours -= 12;
            amPM = !amPM;

            if (hours > 12)
            {
                hours -= 12;
                amPM = !amPM;
            }

        }
        else if (hours == 12)
        {
            amPM = !amPM;
        }
        Console.WriteLine("{0:00}:{1:00}:{2}", hours, mins, amPM ? "AM" : "PM");
    }
}