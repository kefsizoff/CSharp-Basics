using System;

class FibonacciNumbers
{
        //Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
        //(at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. 
        //Note that you may need to learn how to use loops
    static void Main()
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write(Fibonacci(i)+" ");
        }
        Console.WriteLine();
    }
    public static int Fibonacci(int n)
    {
        int a = 0;
        int b = 1;
        // In N steps compute Fibonacci sequence iteratively.
        for (int i = 0; i < n; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return a;
    }
}