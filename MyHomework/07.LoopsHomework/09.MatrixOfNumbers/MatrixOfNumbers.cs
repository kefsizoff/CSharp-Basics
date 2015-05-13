using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MatrixOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Please add number for n (1<=n<=20)");
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        
        if (n >= 1 && n <= 20)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n ; j++)
                {
                    Console.Write(i + j + " ");
                   
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}