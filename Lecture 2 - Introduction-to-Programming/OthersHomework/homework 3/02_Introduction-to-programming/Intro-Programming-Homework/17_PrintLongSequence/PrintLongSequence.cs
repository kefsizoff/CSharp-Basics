using System;


class PrintLongSequence
{
    static void Main()
    {
        for (int i = 2; i <= 1001; i++)
        {
            if (i % 2 == 1)
            {
                Console.WriteLine(-i);
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}