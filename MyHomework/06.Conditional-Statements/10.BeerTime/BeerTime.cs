using System;


class BeerTime
{
    static void Main()
    {
        int hh = int.Parse(Console.ReadLine());
        int mm = int.Parse(Console.ReadLine());
        string ff = Console.ReadLine();
        string invalid = "invalid time";

        if (hh < 1 || hh > 12)
        {
            Console.WriteLine(invalid);
        }
        if (mm < 0 || mm > 59)
        {
            Console.WriteLine(invalid);
        }
        if (ff != "AM" && ff != "PM")
        {
            Console.WriteLine(invalid);
        }

        if (hh >= 1 && hh <= 12)
        {
            if (mm >= 0 && mm <= 59)
            {
                if (ff == "AM" || ff == "PM")
                {
                    if (ff == "AM" && hh >= 0 && hh < 3)
                    {
                        Console.WriteLine("Beer Time");
                    }
                    if (ff == "PM" && hh >= 1 && hh <= 12)
                    {
                        Console.WriteLine("Beer Time");
                    }
                    if ((ff == "AM" && hh >= 3 && hh <= 12) || (ff == "PM" && hh == 0))
                    {
                        Console.WriteLine("non-beer time");
                    }
                }
            }
        }


        //Console.Write("Please, enter the time in a certain format, like this --> 1:30 PM: ");

        //DateTime time = DateTime.Parse(Console.ReadLine());
        //DateTime startTime = DateTime.Parse("1:00 PM");
        //DateTime endTime = DateTime.Parse("3:00 AM");

        //if (time >= startTime || time < endTime)
        //{
        //    Console.WriteLine("Beer time");
        //}
        //else
        //{
        //    Console.WriteLine("Non-beer time");
        //}
    }
}