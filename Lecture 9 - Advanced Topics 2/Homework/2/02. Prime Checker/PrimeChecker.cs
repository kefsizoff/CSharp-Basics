using System;


class PrimeChecker
{
    static void Main(string[] args)
    {
        long num = long.Parse(Console.ReadLine());
        IsPrime(num);
    }
    static void IsPrime(long n)
    {
        bool isPrime = true;
        int squaredNum = (int)Math.Sqrt(n);

        if (n < 2)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i < squaredNum; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                }
            }
        }
        Console.WriteLine(isPrime);
    }
}
