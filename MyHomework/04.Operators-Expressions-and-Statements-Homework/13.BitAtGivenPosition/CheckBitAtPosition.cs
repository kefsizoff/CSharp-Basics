using System;


class CheckBitAtPosition
{
    static void Main()
    {
        int n = 62241;
        int p = 11;
        int nRightP = n >> p;
        int bit = nRightP & 1;
        bool bitAtPos;

        Console.WriteLine(bit == 0 ? bitAtPos = false : true);
    }
}
