using System;


class BonusScore
{
    static void Main()
    {
        Console.Write("Please add a score between 1 and 9:");
        int a = int.Parse(Console.ReadLine());

        if (a >= 1 && a <= 3)
        {
            Console.WriteLine(a * 10);
        }
        else if (a >= 4 && a <= 6)
        {
            Console.WriteLine(a * 100);
        }
        else if (a >= 7 && a <= 9)
        {
            Console.WriteLine(a * 1000);
        }
        else
        {
            Console.WriteLine("Invalid score");
        }
    }
}
