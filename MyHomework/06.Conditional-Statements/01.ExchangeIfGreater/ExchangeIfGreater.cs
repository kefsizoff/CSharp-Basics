using System;


class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Please add number for a:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please add number for b:");
        double b = double.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine(b + " " + a);
        }
        else
        {
            Console.WriteLine(a + " " + b);
        }
    }
}
