using System;
using System.Collections.Generic;
using System.Linq;

class MatrixОfPalindromes
{
    static void Main(string[] args)
    {
        Console.Write("Rows and columns: ");
        string input = Console.ReadLine();

        int rows = int.Parse(Convert.ToString(input[0]));
        int cols = int.Parse(Convert.ToString(input[2]));
                
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write(Convert.ToChar(row + 97));
                Console.Write(Convert.ToChar(row + col + 97));
                Console.Write(Convert.ToChar(row + 97) + " ");
            }
            Console.WriteLine();
        }
    }
}