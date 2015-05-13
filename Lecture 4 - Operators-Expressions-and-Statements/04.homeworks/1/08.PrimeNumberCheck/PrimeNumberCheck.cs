using System;
//Write an expression that checks if given positive integer number n (n ≤ 100) is prime
//(i.e. it is divisible without remainder only to itself and 1). 
class PrimeNumberCheck
{
    static void Main()
    {
        //Console.WriteLine("Please enter number <= 100");
        //int input = int.Parse(Console.ReadLine());
        int input = 4;
        int sqrtInput = (int)Math.Sqrt(input);
        bool primeNumber = true;
        if (input > 1)
        {
            for (int i = 2; i <= sqrtInput; i++)
            {
                if (input % i == 0)
                {
                    primeNumber = false;
                    break;
                }
            }
            Console.WriteLine(primeNumber);
        }
        else
        {
            primeNumber = false;
            Console.WriteLine(primeNumber);
        }
    }
}

