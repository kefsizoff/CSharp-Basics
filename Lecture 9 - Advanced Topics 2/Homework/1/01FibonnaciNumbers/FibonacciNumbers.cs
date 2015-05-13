using System;
namespace _01FibonaciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Fib(n);

        } 
        static void Fib(int n)
        {
            int n1 = 0 ;
            int n2 = 1;
            int nextNumber = 0;

            for (int i = 0; i < n; i++)
            {
                nextNumber = n1 + n2;
                n1 = n2;
                n2 = nextNumber;
            }

            Console.WriteLine(nextNumber);
        }
    }
}
