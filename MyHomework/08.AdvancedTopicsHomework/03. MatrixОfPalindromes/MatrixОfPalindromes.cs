using System;

class MatrixОfPalindromes
{
    static void Main()
    {
        Console.WriteLine("Please add a number for rows");
        int height = int.Parse(Console.ReadLine());
        Console.WriteLine("Please add a number for columns");
        int width = int.Parse(Console.ReadLine());

        string[,] matrix = new string[height, width];
        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                matrix[row, col] =
                    "" + (char)('a' + row) + (char)('a' + col + row) + (char)('a' + row);
            }
        }

        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}
