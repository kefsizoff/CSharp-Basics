using System;
using System.Linq;

class NumberComparer
{
    static void Main()
    {
        //Write a program that gets two numbers from the console and prints the greater of them. 
        //Try to implement this without if statements.

        double[] nums = new double[2];
        Console.Write("a= ");
        nums[0] = double.Parse(Console.ReadLine());
        Console.Write("b= ");
        nums[1] = double.Parse(Console.ReadLine());

        Console.WriteLine("Greater: {0}",nums.Max());
    }
}