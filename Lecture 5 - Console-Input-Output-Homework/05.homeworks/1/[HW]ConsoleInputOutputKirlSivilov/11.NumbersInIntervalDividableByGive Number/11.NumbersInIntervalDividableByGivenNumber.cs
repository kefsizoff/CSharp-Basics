using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.
    class Program
    {
        static void Main()
        {
            Console.Write("Enter first number(must be positive) : ");
            long first = long.Parse(Console.ReadLine());
            while( first <= 0)
            {
                Console.WriteLine("The value must be positive integer!");
                break;
            }
            Console.Write("Enter second number(must be positive) : ");
            long second = long.Parse(Console.ReadLine());
            while (second <= 0)
            {
                Console.WriteLine("The value must be positive integer!");
                break;
            }
            int count = 0;
            for (long i = first; i <= second; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);


        }
    }

