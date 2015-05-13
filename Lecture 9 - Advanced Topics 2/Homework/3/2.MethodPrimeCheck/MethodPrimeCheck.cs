using System;

class MethodPrimeCheck
{
    static bool PrimeCheck(long n)
    {
        int divider = 2;
        int maxdivider = (int)Math.Sqrt(n) +1;
        if (n == 1 || n <= 0)
        {
            return false;
        }


        for (; divider < maxdivider; divider++)
        {

            if (n % divider == 0)
            {
                return false;
            }
        }
        return true;


    }
    static void Main()
    {

        long number = long.Parse(Console.ReadLine());

        bool prime = PrimeCheck(number);
        Console.WriteLine(prime);

    }
}

 