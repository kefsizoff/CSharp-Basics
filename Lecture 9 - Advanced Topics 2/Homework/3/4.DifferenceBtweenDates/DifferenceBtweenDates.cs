using System;
using System.Globalization;

class DifferenceBtweenDates
{
    static void DifferenceInDays(DateTime startDate, DateTime endDate)
    {


        TimeSpan days = (endDate - startDate);

        Console.WriteLine(days.TotalDays);

    }

   
    static void Main()
    {
       //I just Can't Parse the Date format so this programm is taking the format "mm.dd.yyyy"
       
        DateTime startDate =  DateTime.Parse(Console.ReadLine());
        

        DateTime endDate = DateTime.Parse(Console.ReadLine());
       
        DifferenceInDays(startDate, endDate);

    }
}

