using System;
//Write a Boolean expression that returns if the bit at position p 
//(counting from 0, starting from the right) in given integer number n has value of 1. 
class CheckBitAtPosition
{
    static void Main()
    {
        int input = 62241;
        int bitPosition = 11;
        int mask = 1;
        bool hasValue = (input >> bitPosition & mask) != 0;
        Console.WriteLine(hasValue);
    }
}

