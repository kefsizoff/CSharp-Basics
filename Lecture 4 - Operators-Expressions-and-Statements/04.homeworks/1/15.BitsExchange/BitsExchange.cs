using System;
//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
class BitsExchange
{
    static void Main()
    {
        uint input = 2369124121;
        uint mask = 7;
        uint lowThreeBits = input >> 3 & mask;
        uint hiThreeBits = input >> 24 & mask;
        input = ~(mask << 3) & input;   //set bits 3,4  and 5 to zero
        input = ~(mask << 24) & input;  //set bits 24, 25 and 26 to zero
        input |= lowThreeBits << 24;
        input |= hiThreeBits << 3;
        Console.WriteLine(input);
    }
}

