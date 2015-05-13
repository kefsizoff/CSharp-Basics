using System;
class BitShifting
{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());
        int numberOfSieves = int.Parse(Console.ReadLine());
        long[] sieves = new long[numberOfSieves];
        long result = input & ~0L;
        for (int i = 0; i < sieves.Length; i++)
        {
            result = input & ~sieves[0];
            sieves[i] = long.Parse(Console.ReadLine());
        }
        int countOfOnes = 0;
        for (int i = 0; i < sieves.Length; i++)
        {
            result = result & ~sieves[i];
        }
        while (result > 0)
        {
            if ((result & 1) == 1)
            {
                countOfOnes++;
            }
            result = result >> 1;
        }
        Console.WriteLine(countOfOnes);
    }
}

