using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note that you may need to use a for-loop. 
    class Program
    {
        static void Main()
        {
            Console.Write("How many numbers you'll enter :");
            long n = long.Parse(Console.ReadLine());
            decimal sum = 0.00m;
            for(int i=0;i<n;i++)
            {
             decimal numbers=decimal.Parse(Console.ReadLine());
                sum+=numbers;
            }
            Console.WriteLine("The sum of all numbers is : "+sum);
        }
    }

