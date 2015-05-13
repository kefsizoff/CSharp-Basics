using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads 3 real numbers from the console and prints their sum. 
    class Program
    {
        static void Main()
        {
            Console.Title = "SumOfThreeNumbers";
            Console.Write("Enter the first number: ");
            decimal first = decimal.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            decimal second = decimal.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            decimal third = decimal.Parse(Console.ReadLine());
            Console.WriteLine("The sum of {0}+{1}+{2} ={3}",first,second,third,first+second+third);
        }
    }

