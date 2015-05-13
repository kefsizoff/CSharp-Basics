using System;


class BitwiseExtractBit3
{
    static void Main()
    {
        int n = 62241;
        int nRightP = n >> 3;
        int bit = nRightP & 1;

        Console.WriteLine(bit);
    }
}
