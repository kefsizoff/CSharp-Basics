using System;
using System.Collections.Generic;
using System.Linq;

class InsideTheBuilding
{
    static void Main(string[] args)
    {
        int h = int.Parse(Console.ReadLine());
        int[,] points = new int[5, 2];

        for (int i = 0; i < points.GetLength(0); i++)
        {
            for (int j = 0; j < points.GetLength(1); j++)
            {
                points[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < points.GetLength(0); i++)
        {
            bool inside = false;

            if ((points[i, 0] >= 0 && points[i, 0] <= (3 * h)) && ((points[i, 1] >= 0) && (points[i, 1] <= h)) || (points[i, 0] >= h && points[i, 0] <= (2 * h)) && ((points[i, 1] >= h) && (points[i, 1] <= (3 * h))))
            {
                inside = true;
            }

            Console.WriteLine(inside ? "inside" : "outside");
        }
    }
}