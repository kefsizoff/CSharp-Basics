using System;

class Program
{
    static void Main()
    {
        //Write a program that reads 3 real numbers from the console and prints their sum.
        Console.Write("a=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b=");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c=");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("a+b+c+={0:F2}",a+b+c);
    }
}