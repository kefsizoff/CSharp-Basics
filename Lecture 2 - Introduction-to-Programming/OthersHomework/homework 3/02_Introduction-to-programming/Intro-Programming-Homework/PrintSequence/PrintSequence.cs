using System;

class PrintSequence
{
    static void Main()
    {
       
        for (int n = 2; n <= 11; n++)
        {
            if (n % 2 == 1)
            {
                Console.WriteLine(-n);
            }
            else
            {
                Console.WriteLine(n);
            }

        }
    }
}

