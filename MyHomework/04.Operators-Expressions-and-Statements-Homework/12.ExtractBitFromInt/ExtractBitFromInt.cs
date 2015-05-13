using System;


class ExtractBitFromInt
{
    static void Main()
    {
        int p = 7;
        int n = 5343;
        int nRightP = n >> p;
        int bit = nRightP & 1;

        Console.WriteLine(bit);
    }
}
