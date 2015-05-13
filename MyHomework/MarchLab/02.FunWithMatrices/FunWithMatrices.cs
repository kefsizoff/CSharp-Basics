using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FunWithMatrices
{
    static void Main()
    {
        double startValue = double.Parse(Console.ReadLine());
        double step = double.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        double currentValue = startValue;
        double[,] matrix = new double[4, 4];
        
        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                matrix[row, col] = currentValue;
                currentValue += step;
            }
        }

        while (input != "Game Over!")
        {
            string[] order = input.Split(' ');
            int row = int.Parse(order[0]);
            int col = int.Parse(order[1]);
            string command = order[2];
            double num = double.Parse(order[3]);

            switch (command)
            {
                case "power":
                    matrix[row, col] = Math.Pow(matrix[row, col], num); 
                    break;

                case "multiply":
                    matrix[row, col] = matrix[row, col] * num;
                    break;

                case "sum":
                    matrix[row, col] = matrix[row, col] + num;
                    break;
            }
            input = Console.ReadLine();

        }

        //Print matrix...

        for (int row = 0; row < 4; row++)
        {
            Console.WriteLine();
            for (int col = 0; col < 4; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
        }
        Console.WriteLine();


        // COL SUMS
        double colSum = 0;

        double colSum0 = matrix[0, 0] + matrix[1, 0] + matrix[2, 0] + matrix[3, 0];
        double colSum1 = matrix[0, 1] + matrix[1, 1] + matrix[2, 1] + matrix[3, 1];
        double colSum2 = matrix[0, 2] + matrix[1, 2] + matrix[2, 2] + matrix[3, 2];
        double colSum3 = matrix[0, 3] + matrix[1, 3] + matrix[2, 3] + matrix[3, 3];
        Console.WriteLine(colSum0);
        Console.WriteLine(colSum1);
        Console.WriteLine(colSum2);
        Console.WriteLine(colSum3);

        // ROW SUMS
        
        double rowSum0 = matrix[0, 0] + matrix[0, 1] + matrix[0, 2] + matrix[0, 3];
        double rowSum1 = matrix[1, 0] + matrix[1, 1] + matrix[1, 2] + matrix[1, 3];
        double rowSum2 = matrix[2, 0] + matrix[2, 1] + matrix[2, 2] + matrix[2, 3];
        double rowSum3 = matrix[3, 0] + matrix[3, 1] + matrix[3, 2] + matrix[3, 3];
        Console.WriteLine(rowSum0);
        Console.WriteLine(rowSum1);
        Console.WriteLine(rowSum2);
        Console.WriteLine(rowSum3);
            
        

            
        

    }
}