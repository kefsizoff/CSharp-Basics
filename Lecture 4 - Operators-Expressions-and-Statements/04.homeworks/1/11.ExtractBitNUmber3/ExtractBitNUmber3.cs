﻿using System;
//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0.
class ExtractBitNUmber3
{
    static void Main()
    {
        int input = 62241;
        int mask = 1;
        int bitValue = input >> 3 & mask;
        Console.WriteLine(bitValue);
    }
}

