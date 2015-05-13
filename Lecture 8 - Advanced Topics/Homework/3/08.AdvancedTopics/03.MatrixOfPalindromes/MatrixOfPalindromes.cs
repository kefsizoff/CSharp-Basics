using System;
class MatrixOfPalindromes
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');
        int r = int.Parse(inputArray[0]);
        int c = int.Parse(inputArray[1]);
        string[,] matrix = new string[r, c];

        for (int row = 0; row < r; row++)
        {
            for (int col = 0; col < c; col++)
            {
                matrix[row, col] = "" + (char)('a' + row) + (char)('a' + row + col) + (char)('a' + row);
            }
        }
        for (int row = 0; row < r; row++)
        {
            for (int col = 0; col < c; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}