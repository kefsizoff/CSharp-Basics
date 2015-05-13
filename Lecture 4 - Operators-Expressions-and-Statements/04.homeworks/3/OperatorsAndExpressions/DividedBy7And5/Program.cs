using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter number for check: ");
        int number = int.Parse(Console.ReadLine());
        bool divided = (number % 5 == 0) && (number % 7 == 0);
        Console.WriteLine("Divided by 7 and 5? : " + divided);
    }
}

