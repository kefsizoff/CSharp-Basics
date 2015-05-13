using System;
using System.Globalization;
using System.Threading;


class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Please, enter the time in a certain format, like this --> 1:30 PM: ");

        DateTime time = DateTime.Parse(Console.ReadLine());
        DateTime startTime = DateTime.Parse("1:00 PM");
        DateTime endTime = DateTime.Parse("3:00 AM");

        if (time >= startTime || time < endTime)
        {
            Console.WriteLine("Beer time");
        }
        else
        {
            Console.WriteLine("Non-beer time");
        }
    }
}

