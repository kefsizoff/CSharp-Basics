using System;


class PrimeNumCheck
{
    static void Main()
    {
        bool isPrime = true;
        for (int i = 2; i <= 100; i++)
        {
            for (int j = 2; j <= 100; j++)
            {
                if (i != j && i % j == 0) 
                {                         
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine(i);
            }
            isPrime = true;
        }
    }
}