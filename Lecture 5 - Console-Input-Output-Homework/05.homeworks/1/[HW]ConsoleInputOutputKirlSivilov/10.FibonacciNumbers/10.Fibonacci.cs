using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. Note that you may need to learn how to use loops. 
    class Program
    {
        static void Main()
        {
            Console.Write("Enter n: ");
            long n = long.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int sum = (a + b);
            Console.Write("0 ");
            Console.Write("1 ");
            for (long i = 0; i <n; i++)
            {
                a = b;
                b = sum;
                sum = a + b;
                Console.Write(sum + " ");
            }

            Console.WriteLine();
          
            
        }
    }

