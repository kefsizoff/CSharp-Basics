using System;

//Write a program that reads 3 real numbers from the console 
//and prints their sum. 
  
class SumOf3Numbers
    {
        static void Main()
        {
            Console.Write("Please insert number a=: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Please insert number b=: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Please insert number c=: ");
            double c = double.Parse(Console.ReadLine());

            double sum = a + b + c;

            Console.WriteLine("The sum of the numbers is {0}", sum);
        }
    }
