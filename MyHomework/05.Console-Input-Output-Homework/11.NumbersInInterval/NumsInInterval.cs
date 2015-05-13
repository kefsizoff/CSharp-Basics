using System;


class NumsInInterval
{
    static void Main()
    {
        Console.WriteLine("write a number a");
        double firstNum = double.Parse(Console.ReadLine());

        Console.WriteLine("write a number b");
        double secondNum = double.Parse(Console.ReadLine());

        int count = 0;
        for (double i = firstNum; i < secondNum; i++)
        {
            if (i % 5 == 0)
            {
                Console.WriteLine(i);
                count++;

            }
        }
        Console.WriteLine(count);
    }
}