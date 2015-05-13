using System;
//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p 
//from the binary representation of n while preserving all other bits in n.
class ModifyBitAtPosition
{
    static void Main()
    {
        int input = 5343;
        int position = 7;
        int newBitValue = 0;
        int mask = 1;
        int newNumber = 0;
        int oldBitValue = input >> position & mask;
        if (newBitValue != oldBitValue && newBitValue == 0)
        {
            newNumber = ~(mask << position) & input;
            Console.WriteLine(newNumber);
        }
        else if (newBitValue == oldBitValue)
        {
            Console.WriteLine(input);
        }
        else
        {
            newNumber = mask << position | input;
            Console.WriteLine(newNumber);
        }
    }
}

