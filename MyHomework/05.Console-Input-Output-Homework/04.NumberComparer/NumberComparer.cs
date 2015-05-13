using System;

//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements. 

class NumberComparer
{
    static void Main()
    {
        Console.Write("A=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("B=");
        double b = double.Parse(Console.ReadLine());
        
        double greater = ((a >= b) ? a : b);
        Console.WriteLine("The number {0} is greater", greater);
    }
}
