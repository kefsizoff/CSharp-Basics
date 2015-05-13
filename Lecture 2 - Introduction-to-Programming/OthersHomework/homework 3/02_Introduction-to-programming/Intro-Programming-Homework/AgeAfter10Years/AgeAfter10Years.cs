using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("Your birthday year: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Your birthday month: ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Your birthday day: ");
        int day = int.Parse(Console.ReadLine());
        DateTime birthDay = new DateTime(year, month, day);
        DateTime now = DateTime.Now;
        int totalDays = (int)(now - birthDay).TotalDays;
        Console.WriteLine("Now you are {0} days old.", totalDays);
        DateTime tenYearsLater = now.AddYears(10); 
        totalDays = (int)(tenYearsLater - birthDay).TotalDays;
        Console.WriteLine("After 10 years you'll be {0} days old.", totalDays/365); 
    }
}