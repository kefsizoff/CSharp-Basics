//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
//and prints a matrix like in the examples below. Use two nested loops

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Enter an integer number in the range (1 <= n <= 20):");
        int n = int.Parse(Console.ReadLine());
        int countCol = 1;

        if (n < 1 || n > 20)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j < 2 * n; j++)
            {
                if (countCol <= n)
                {
                    Console.Write(j + " ");
                    countCol++;
                }
            }
            Console.WriteLine();
            countCol = 1;
        }
    }
}