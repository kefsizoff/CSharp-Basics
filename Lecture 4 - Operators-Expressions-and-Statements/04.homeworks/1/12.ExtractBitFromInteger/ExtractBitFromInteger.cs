using System;
//Write an expression that extracts from given integer n the value of given bit at index p. 
class ExtractBitFromInteger
{
    static void Main()
    {
        int input = 62241;
        int index = 11;
        int mask = 1 << index;
        int bitValue = input & mask;
        bitValue = bitValue >> index;
        Console.WriteLine(bitValue);
    }
}

