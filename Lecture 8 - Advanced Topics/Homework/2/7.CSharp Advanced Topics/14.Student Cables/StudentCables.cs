using System;
using System.Collections.Generic;
using System.Linq;

class StudentCables
{
    static void Main(string[] args)
    {
        byte n = byte.Parse(Console.ReadLine());

        string[,] stringCableLength = new string[n, 2];
        ushort[] numCableLengthCantimeters = new ushort[n];

        for (int i = 0; i < stringCableLength.GetLength(0); i++)
        {
            for (int j = 0; j < stringCableLength.GetLength(1); j++)
            {
                stringCableLength[i, j] = Console.ReadLine();
            }
            if (stringCableLength[i, 1] == "meters")
            {
                numCableLengthCantimeters[i] = ushort.Parse(stringCableLength[i, 0]);
                numCableLengthCantimeters[i] *= 100;
            }
            else
            {
                numCableLengthCantimeters[i] = ushort.Parse(stringCableLength[i, 0]);
            }
        }
        int totalCableLegth = 0;
        int splices = 0;
        for (int i = 0; i < numCableLengthCantimeters.Length; i++)
        {
            if (numCableLengthCantimeters[i] >= 20)
            {
                totalCableLegth += numCableLengthCantimeters[i];
                splices++;
            }
        }

        totalCableLegth -= (3 * (splices - 1));

        Console.WriteLine(totalCableLegth / 504);
        Console.WriteLine(totalCableLegth % 504);
    }
}

