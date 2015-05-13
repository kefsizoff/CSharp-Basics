using System;


class NumbersFroma1ToN
{
    static void Main()
    {
        Console.Write("Please add an integer number:");
        int n = int.Parse(Console.ReadLine());
        int counter = 1;
        while (counter <= n)
        {
            Console.WriteLine(counter);
            counter++;
        }
    }
}